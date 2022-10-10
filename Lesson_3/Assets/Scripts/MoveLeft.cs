/*
 * Autor: Noemi Perez Vega
 * Fecha: 07/10/2022
 * Descripción: Clase para mover objetos a la izquierda en el eje de las x.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //Variable para definir la velocidad
    private float speed = 30;
    //Objeto con el script del jugador
    private PlayerController playerControllerScript;
    //Variable con el límite que puede alcanzar
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        //Obtiene el objeto correspondiente al jugador
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Valida si el juego aún continua
        if (playerControllerScript.gameOver == false)
        {
            //Se mueve hacia la izquierda
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //Valida que el objeto cruce el límite del área de juego
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle") )
        {
            //Elimina el objeto
            Destroy(gameObject);
        }
        
    }
}
