/*
 * Autor: Noemi Perez Vega
 * Fecha: 07/10/2022
 * Descripción: Clase para lanzar los objetos con los que interactua el jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Variable para establecer los objetos que serán lanzados
    public GameObject obstaclePrefab;
    //Variable con la posición que tendrán los objetos lanzados
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    //Variable con el tiempo de espera entre los lanzamientos
    private float startDelay = 2;
    //Variable con el intervalo de tiempo con el que se producen los objetos
    private float repeatRate = 2;
    //Variable con el script del jugador
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        //Se obtiene el objeto correspondiente al jugador
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        //Se manda llamar la función para lanzar obstáculos
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Función para generar nuevos objetos
    void SpawnObstacle()
    {
        //Valida que el juego continue
        if(playerControllerScript.gameOver == false)
        {
            //Genera un nuevo objeto
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
