/*
 * Autor: Noemi Perez Vega
 * Fecha: 07/10/2022
 * Descripci�n: Clase para controlar los movimientos y acciones del jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable con el componente RigidBody
    private Rigidbody playerRb; 
    //Variable con el componente Animator, para apllicar la animaci�n en el jugador
    private Animator playerAnim;
    //Variable con el componente para agregar audio al juego
    private AudioSource playerAudio;
    //Variable con el componente Paarticle para agregar efectos de explosi�n al juego
    public ParticleSystem explosionParticle;
    //Variable con el componente Particle para agregar efectos de polvo al correr
    public ParticleSystem dirtParticle;
    //Variable para aplicar sonido de salto
    public AudioClip jumpSound;
    //Variable para aplicar sonido de choque
    public AudioClip crashSound;
    //Variable para aplicar fuerza o impulso al jugador
    public float jumpForce = 10;
    //Variable para cambiar la gravedad que se tiene establecida
    public float gravityModifier;
    //Varaible  para determinar si el jugador est� en el suelo
    public bool isOnGround = true;
    //Variable para determinar si el juego termin�
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        //Asigna el componente RigidBody
        playerRb = GetComponent<Rigidbody>();
        //Asigna el componente para las animaciones
        playerAnim = GetComponent<Animator>();
        //Asigna el componente para el audio
        playerAudio = GetComponent<AudioSource>();
        //Asigna el componente para cambiar los par�metros de la gravedad
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //Valida que se precione la tecla de espacio, el jugador se encuentre en el suelo y que el juego a�n no termine.
        if (Input.GetKeyDown(KeyCode.Space)&& isOnGround && !gameOver)
        {
            //Se aplica un salto o impulso al jugador
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //Establece que el jugador se encuentra saltando
            isOnGround = false;
            //Aplica efecto de salto
            playerAnim.SetTrigger("Jump_trig");
            //Quita el efecto de estar corriendo
            dirtParticle.Stop();
            //Reproduce el sonido de salto
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    //Funci�n para determinar lo que ocurre cuando dos objetos entran en colici�n
    private void OnCollisionEnter(Collision collision)
    {
        //isOnGround = true;
        //Valida que el objeto sea el suelo
        if (collision.gameObject.CompareTag("Ground"))
        {
            //Establece que el jugador se encuentra en el suelo
            isOnGround = true;
            //Produce efecto de estar corriendo
            dirtParticle.Play();
        }
        //Valida que el objeto corresponda a un obst�culo
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            //Manda mensaje de juego terminado
            Debug.Log("Game Over!!");
            //Establece la variable de juego terminado, como verdadero
            gameOver = true;
            //Aplica animaci�n de muerte
            playerAnim.SetBool("Death_b", true);
            //Establece el tipo de muerte seleccionada
            playerAnim.SetInteger("DeathType_int", 1);
            //Produce efecto de explosi�n
            explosionParticle.Play();
            //Quita el efecto de estar corriendo
            dirtParticle.Stop();
            //Reproduce el sonido de choque
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
 