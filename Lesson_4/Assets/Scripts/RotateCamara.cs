/*
 * Autor: Noemi Pérez Vega
 * Fecha: 06/10/2022
 * Descripción: Clase con el método para controlar los movimientos y la posición de la cámara de acuerdo al jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamara : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once pe r frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
