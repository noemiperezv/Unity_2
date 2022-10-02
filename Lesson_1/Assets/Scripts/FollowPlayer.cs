/*
 * Autor: Noemi Perez Vega
 * Fecha: 29/09/2022
 * Descripción: Archivo para controlar la posición y movimiento de la cámara respecto al jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Variable que establece el jugador (objeto a seguir)
    public GameObject player;
    //Posición de la cámara
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Se establece la cámara detrás del jugador agregando la posición de este.
        transform.position = player.transform.position + offset;
    }
}
