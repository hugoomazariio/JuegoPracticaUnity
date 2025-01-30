using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuSystem : MonoBehaviour
{
    public void Jugar()
    {
        // Me permite cambiar de escena, en este caso va a cambiar a la escena de juego
        // 1 Menu, 2 Juego, 3 Game Over
        SceneManager.LoadScene(2);
    }

    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        // Application.Quit(); // Esto solo va a funcionar cuando el juego este exportado, ejecutándolo en unity no funcionará
        UnityEditor.EditorApplication.isPlaying = false; // Va a terminar la ejecución del programa.
    }
}
