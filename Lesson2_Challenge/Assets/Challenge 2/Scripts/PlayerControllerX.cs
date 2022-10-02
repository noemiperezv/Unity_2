﻿/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Contiene las funciones que puede realizar el jugador
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float waitTime = 1;
    private float timeNextShot = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > timeNextShot)
        {
            timeNextShot = Time.time + waitTime;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
