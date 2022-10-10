/*
 * Autor: Noemi Perez Vega
 * Fecha: 07/10/2022
 * Descripción: Clase para repetir de manera continua la imagen o paisaje de fondo.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{//Variable para guardar la posición de inicio
    private Vector3 startPos;
    //Variable para guardar el ancho del fondo.
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            //Se reestablece la posición
            transform.position = startPos;
        }
    }

 
}


