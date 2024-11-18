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

    bool isGrounded; //Me va a decir si está tocando el suelo mediante true o false


    Vector3 velocity;

    public float jumpHeight = 2f;

    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, sphereRadius, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -3f;
        }


        float x = Input.GetAxis("Horizontal"); //Teclas A y D, funcionan también para  mando
        float z = Input.GetAxis("Vertical"); //Teclas W y S, funcionan también para mando

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) //Salto personaje
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }




        characterController.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);









    }
}