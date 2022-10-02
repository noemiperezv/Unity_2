/*
 * Autor: Noemi Perez Vega
 * Fecha: 30/09/2022
 * Descripción: Archivo para controlar el lanzamiento de perros por parte del jugador, y el lanzamiento de pelotas de
 * manera automática.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    //Variable para asignar el objeto que servirá como pelota
    public GameObject[] ballPrefabs;
    //Variable que establece el límite del lado izquierdo
    private float spawnLimitXLeft = -22;
    //Variable que establece el límite del lado derecho
    private float spawnLimitXRight = 7;
    //Variable que establece el lanzamiento en la posición del eje Y.
    private float spawnPosY = 30;
    //Variable con el tiempo de espera
    private float startDelay = 1.0f;
    //Variable que establece el intervalo permitido para realizar el lanzamiento
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Invoca una sola vez el lanzamiento de la pelota.
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //Se crea una variable que definira el color de las pelotas.
        int ball = Random.Range(0, 3);
        // Generate una pelota aleatoria para el jugador
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Genera una nueva instancia de la pelota
        // Se sustituye el 0 con la variable ball.
        Instantiate(ballPrefabs[ball], spawnPos, ballPrefabs[ball].transform.rotation);

        //Se modifica el valor de la variable startDelay para que la función SpawnRandomBall se invoque.
        startDelay = Random.Range(1, 4);
        Invoke("SpawnRandomBall", startDelay);
    }

}
