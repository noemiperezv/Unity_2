﻿/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Archivo para eliminar los objetos(perros o pelotas) que se crucen el límite del área de juego.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    //Se define el valor del límite que pueden alcanzar los perros.
    private float leftLimit = -40;
    //Se define el valor del límite que pueden alcanzar las pelotas.
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Se destruyen los perros cuando llegan al límite.
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Se destruyen las pelotas cuando llegan al límite.
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
