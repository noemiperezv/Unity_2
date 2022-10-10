/*
 * Autor: Noemi Perez Vega
 * Fecha: 07/10/2022
 * Descripción: Clase para definir las acciones y movimientos del jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Variable para determinar si el juego ya ha terminado
    public bool gameOver;
    //Variable para definar la fuerza que se va a aplicar
    public float floatForce;
    //Variable con el valor de la gravedad que se va a aplicar
    private float gravityModifier = 1.5f;
    //Variable que contiene las propiedades del componente RigidBody
    private Rigidbody playerRb;
    //Variable para definir el límite que puede alcanzar en el eje de las y
    private float boundY = 12;
    //Variable para establecer si aún puede elevarse
    private bool elevate;
    //Variable para insertar el efecto de explosión
    public ParticleSystem explosionParticle;
    //Variable para insertar el efecto de fuegos artificiales
    public ParticleSystem fireworksParticle;
    //Variable para asignar audio de fondo
    private AudioSource playerAudio;
    //Variable para aplicar un sonido al tocar una dinero
    public AudioClip moneySound;
    //Variable para aplicar un sonido al tocar una bomba
    public AudioClip explodeSound;
    //Variable para aplicar sonido al hacer un rebote contra el suelo
    public AudioClip boingSound;


    // Start is called before the first frame update
    void Start()
    {
        //Se obtiene el balor del componente RigidBody
        playerRb = GetComponent<Rigidbody>();///se agrega para controlar el jugador.
        //Se modifica la gravedad que se tiene establecida
        Physics.gravity *= gravityModifier;
        //Se obtiene la pista de audio que se usara de fondo
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        //Valida que el jugador se encuentre dentro del límite establecido
        if(transform.position.y < boundY)
        {
            //Se establece la variable en verdadero
            elevate = true;
        }
        else
        {
            //Se establece la variable en falso
            elevate = false;
        }
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver && elevate)
        {
            //Se aplica fuerza/impulso al jugador
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            //Produce efecto de explosión
            explosionParticle.Play();
            //Reproduce el sonido de explosión
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            //Establece la variable de juego terminado como verdadero
            gameOver = true;
            //Manda mensaje de juego termindao
            Debug.Log("Game Over!");
            //Se elimina el objeto con el que chocó
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            //Produce efecto de fuegos artificiales
            fireworksParticle.Play();
            //Reproduce sonidio de dinero
            playerAudio.PlayOneShot(moneySound, 1.0f);
            //Destruye el objeto con el que chohó
            Destroy(other.gameObject);

        }
        //Valida si el jugador toca el suelo
        else if (other.gameObject.CompareTag("Ground"))
        {
            //Aplica un impulso para que el jugador salte/rebote
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            //Reproduce sonido de rebote
            playerAudio.PlayOneShot(boingSound, 1.0f);
        }

    }

}
