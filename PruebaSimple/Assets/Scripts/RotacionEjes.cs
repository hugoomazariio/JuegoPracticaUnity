using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionEjes : MonoBehaviour
{
    // Velocidad de rotación en los ejes X,Y y Z
    public float rotationSpeedX = 10f;
    public float rotationSpeedY = 20f;
    public float rotationSpeedZ = 30f;

    // Update is called once per frame
    void Update()
    {
        //Rotar el cubo en funcion del tiempo y la velocidad definida
        transform.Rotate(rotationSpeedX * Time.deltaTime, rotationSpeedY * Time.deltaTime, rotationSpeedZ * Time.deltaTime);
    }
}
