/*
 * Autor: Noemi Perez Vega
 * Fecha: 29/09/2022
 * Descripción: Archivo para controlar el movimiento de rotación de la hélice de la avioneta.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speedRotation = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speedRotation);
    }
}
