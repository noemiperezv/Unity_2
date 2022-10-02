/*
 * Autor: Noemi Perez Vega
 * Fecha: 29/09/2022
 * Descripci�n: Archivo para controlar la posici�n y movimiento de la c�mara respecto al jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Variable que establece el jugador (objeto a seguir)
    public GameObject player;
    //Posici�n de la c�mara
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Se establece la c�mara detr�s del jugador agregando la posici�n de este.
        transform.position = player.transform.position + offset;
    }
}
