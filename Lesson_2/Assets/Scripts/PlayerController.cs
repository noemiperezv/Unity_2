/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Archivo para controlar los movimientos y acciones del jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable para determinar los movimientos en el eje de la x.
    public float horizontalInput;
    //Variable para determinar la velocidad con la que avanzará
    public float speed = 10.0f;
    //Variable que determina el rango
    public float xRange = 10.0f;

    //Varíable para asignar el objeto que será lanzado
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Condición para verificar si la posición de la x es menor a la establecida como límite.
        if (transform.position.x < -xRange)
        {
            //Se realiza un movimiento cambiando la posición
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Valida si la posición de la x es mayor a la que se estableció como límite.
        if (transform.position.x > xRange)
        {
            //Se realiza un movimiento cambiando la posición
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Se obtiene el movimiento realizado por el usuario con las teclas izquierda o derecha
        horizontalInput = Input.GetAxis("Horizontal");
        //Se realiza un giro o rotación
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Valida si se preciona la tecla de espacio
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Lanzar un proyectil desde el jugador
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
