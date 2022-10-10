/*
 * Autor: Noemi Perez Vega
 * Fecha: 07/10/2022
 * Descripción: Clase para mover objetos a la izquierda en el eje de las x.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    //Variable para controlar la velocidad del movimiento
    public float speed;
    //Variable para asignar el objeto al que se le va a aplicar el movimiento
    private PlayerControllerX playerControllerScript;
    //Variable para definir el límite de la izquierda
    private float leftBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        //Se asigna el objeto con nombre Player
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // Valida que el juego no haya terminado
        if (!playerControllerScript.gameOver)
        {
            //Se aplica el movimiento al objeto
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        // Valida que el objeto este fuera de los límites
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
