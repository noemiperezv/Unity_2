/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Archivo para detectar cuando dos objetos colisionan o entran en contacto.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Detecta que dos objetos entren en contacto (uno de los animales, con la cómida)
    void OnTriggerEnter(Collider other)
    {
        //Se eliminan ambos objetos
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
