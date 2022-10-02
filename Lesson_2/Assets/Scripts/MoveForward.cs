/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Archivo para controlar el movimiento hacia adelante de los objetos.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //Variable que determina la velocidad con la que avanza.
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se mueven los objetos hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
