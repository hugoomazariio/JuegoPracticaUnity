using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuSystem : MonoBehaviour
{
    public void Jugar()
    {
        GameManager.Instance.CargarJuego(); 
    }

    public void Salir()
    {
        GameManager.Instance.SalirJuego(); 
    }
}
