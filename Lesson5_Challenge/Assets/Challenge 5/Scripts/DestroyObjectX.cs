/*
 * Autor: Noemi Pérez Vega
 * Fecha: 20/10/2022
 * Descripción: Clase para destruir los objetos generados, despues de dos segundos.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
