/*
 * Autor: Noemi Perez Vega
 * Fecha: 07/10/2022
 * Descripción: Clase para lanzar los diferentes objetos con los que interactua el jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    //Variable para obtener los objetos prefabricados
    public GameObject[] objectPrefabs;
    //Variable con el tiempo que debe esperar para lanzar el siguiente objeto
    private float spawnDelay = 2;
    //Variable con el intervalo de tiempo que habra entre dos objetos lanzados
    private float spawnInterval = 1.5f;
    //Varaible para obtener el script del jugador
    private PlayerControllerX playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //Manda llamar de manera repetitiva la función SpawnObjects
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        //Obtiene el componente correspondiente al jugador.
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Spawn obstacles
    void SpawnObjects ()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);
        //Variable con el rango de objetos que podrán ser lanzados
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (!playerControllerScript.gameOver)
        {
            //Lanzamiento de un nuevo objeto
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }

    }
}
