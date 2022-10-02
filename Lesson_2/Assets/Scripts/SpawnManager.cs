/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Archivo para controlar el lanzamiento de objetos.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Variable para asignar los objetos que serviran como animales.
    public GameObject[] animalPrefabs;
    //Variable para establecer el rango de los límites permitidos.
    private float spawnRangeX = 10;
    //Variable con la posición en z
    private float spawnPosZ = 20;
    //Variable con el tiempo de espera
    private float startDelay = 2;
    //Variable con el valor del intervalo
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //Se manda llamar la función que genera los animales (de manera repetitiva)
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //Valida si se presiona la tecla "S"
        if(Input.GetKeyDown(KeyCode.S))
        {
            //Genera un animal
            SpawnRandomAnimal();
        }
    }

    //Función para generar un animal
    void SpawnRandomAnimal()
    {
        //Variable con valores aleatorios para generar diferentes animales
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Establece la posición de inicio
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        //Crea un nuevo objeto(animal)
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
