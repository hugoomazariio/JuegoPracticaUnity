using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMenu : MonoBehaviour
{
    void Start()
    {
        // Asegura que el cursor sea visible y desbloqueado cuando se carga la escena de Game Over
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Reiniciar()
    {
        GameManager.Instance.CargarJuego();
    }

    public void Salir()
    {
        GameManager.Instance.SalirJuego();
    }
}

