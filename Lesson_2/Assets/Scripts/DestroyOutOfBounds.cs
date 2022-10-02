/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Archivo para destruir los objetos que atraviesan el límite del área de juego.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Variable para establecer el límite mayor/superior
    private float topBound = 25;
    //Variable para establecer el límite menor/inferior
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Condición para verificar si un objeto atraviesa el limite superior
        if(transform.position.z > topBound)
        {
            //Se elimina el objeto
            Destroy(gameObject);
            //Condición para verificar si un objeto atraviesa el límite inferior
        }else if(transform.position.z < lowerBound)
        {
            //Muestra mensaje en consola
            Debug.Log("Game Over!");
            //Se destruye el objeto
            Destroy(gameObject);
        }
    }
}
