/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Archivo para percibir la interacción que se produce cuando dos objetos chocan (el perro y la pelota).
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    //Función que se ejecuta al detectar el choque entre dos objetos
    private void OnTriggerEnter(Collider other)
    {
        //Destruye el objeto
        Destroy(gameObject);
    }
}
