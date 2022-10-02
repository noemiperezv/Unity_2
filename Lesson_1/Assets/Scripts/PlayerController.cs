using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables privadas
    //Variable que determina la velocidad con la que avanza
    private float speed = 5.0f;
    //Variable que determina la velocidad con la que gira/rota
    private float turnSpeed = 25.0f;
    //Variable para determinar los movimientos en el eje de la x
    private float horizontalInput;
    //Variable para determinar los movimientos hacia adelante y atrás
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se obtienen los valores de entrada de las teclas derecha e izquierda
        horizontalInput = Input.GetAxis("Horizontal");
        //Se obtienen los valores de entrada de las teclas arriba y abajo
        forwardInput = Input.GetAxis("Vertical");
        //Mover el vehículo hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotar el vehículo
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
