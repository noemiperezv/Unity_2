﻿/*
 * Autor: Noemi Perez Vega
 * Fecha: 29/09/2022
 * Descripción: Archivo para controlar la posición y movimiento de la cámara respecto al jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    //Variable con los valores de los ejes x, y, z de la posición de la cámara.
    private Vector3 offset = new Vector3(19, 3, 1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
