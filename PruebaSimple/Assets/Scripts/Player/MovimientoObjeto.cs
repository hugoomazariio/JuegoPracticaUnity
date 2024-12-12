using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR;

public class MovimientoObjeto : MonoBehaviour 
{


    public CharacterController characterController;

    public float speed = 10f;

    private float gravity = -9.81f;

    public Transform groundCheck;
    public float sphereRadius = 0.3f;
    public LayerMask groundMask;

    bool isGrounded; //Transform que me va a decir si est� tocando el suelo mediante true o false


    Vector3 velocity;

    public float jumpHeight = 2f;

    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, sphereRadius, groundMask);
        //Verifica si hay una colisi�n entre una esfera (centrada en groundCheck.position y con radio sphereRadius) y objetos de la capa groundMask.


        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -3f;
        }
        // Si el personaje est� en el suelo (isGrounded == true) y su velocidad vertical (velocity.y) es menor que 0, se ajusta a un valor peque�o (-3f)
        // para mantenerlo pegado al suelo.


        float x = Input.GetAxis("Horizontal"); //Teclas A y D, funcionan tambi�n para  mando
        float z = Input.GetAxis("Vertical"); //Teclas W y S, funcionan tambi�n para mando

        Vector3 move = transform.right * x + transform.forward * z;
        // Vector de movimiento que combina la direcci�n hacia la derecha (transform.right) y hacia adelante (transform.forward) del objeto

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) //Salto personaje, detecta si el jugador pulsa la barra espaciadora.
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
        // Si el personaje est� en el suelo (isGrounded) y se presiona la tecla de salto, se calcula la velocidad vertical necesaria para alcanzar la altura deseada
        // usando la f�rmula: velocidad inicial = Raiz de (2. altura de salto . gravedad)

        characterController.Move(move * speed * Time.deltaTime); // El movimiento horizontal se escala por la velocidad (speed) y el tiempo entre fotogramas (Time.deltaTime).

        velocity.y += gravity * Time.deltaTime; // La gravedad afecta la componente vertical de la velocidad

        characterController.Move(velocity * Time.deltaTime); // El movimiento vertical se aplica tambi�n con characterController.Move, acumulando el efecto de la gravedad.
      
    }
}
