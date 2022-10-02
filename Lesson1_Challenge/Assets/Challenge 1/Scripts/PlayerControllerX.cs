/*
 * Autor: Noemi Perez Vega
 * Fecha: 29/09/2022
 * Descripción: Archivo para controlar los movimientos y acciones del jugador.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Se obtinene el valor ingresado por el usuario al usar las teclas arriba/abajo
        verticalInput = Input.GetAxis("Vertical");

        // Mover la avioneta hacia adelante cada segundo(Se cambia la palabra back por forward y se agrega la constante Time.deltaTime)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Dirigir la avioneta hacia arriba o abajo con dichas teclas (Se agrega la variable verticalInput que obtiene los movimientos del jugador
        // y se cambia la palabra right por left para ajustar el uso de los controles)
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
