/*
 * Autor: Noemi Perez Vega
 * Fecha: 07/10/2022
 * Descripci�n: Clase para repetir de manera continua la imagen o escena de fondo.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //Variable para guardar la posici�n de inicio
    private Vector3 startPos;
    //Variable para guardar el ancho de la escena
    private float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        //Inicializa la variable con la posici�n actual
        startPos = transform.position;
        //Obtiene el ancho de la imagen
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Valida que la posici�n actual sea menor a la de la imagen
        if (transform.position.x < startPos.x-repeatWidth)
        {
            //Repite la imagen
            transform.position = startPos;
        }
    }
}
