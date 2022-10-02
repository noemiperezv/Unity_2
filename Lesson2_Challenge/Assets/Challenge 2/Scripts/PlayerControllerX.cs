/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Contiene las funciones que puede realizar el jugador
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Variable que asigna el objeto a un jugador
    public GameObject dogPrefab;
    //Variable con el tiempo de espera
    private float waitTime = 1;
    //Variable para determinar el tiempo en el que se hará el proxímo lanzamiento
    private float timeNextShot = 0;

    // Update is called once per frame
    void Update()
    {
        // Valida que se precione la tecla de espacio y que haya transcurrido el tiempo de espera
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > timeNextShot)
        {
            //Suma un segundo al tiempo para el siguiente disparo/lanzamiento
            timeNextShot = Time.time + waitTime;
            //Genera un nuevo objeto de tipo perro
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
