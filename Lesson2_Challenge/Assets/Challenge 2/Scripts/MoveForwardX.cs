/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Archivo para que los perros avancen hacia adelante en cuanto sean lanzados por el jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    //Variable para determinar la velocidad
    public float speed;

    // Update is called once per frame
    void Update()
    {
        //Produce el movimiento hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
