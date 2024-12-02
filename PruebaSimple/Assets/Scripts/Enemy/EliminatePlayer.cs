using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Acceso a las herramientas de cambios de escena

public class EliminatePlayer : MonoBehaviour
{

    // Este método se llama cuando el enemigo colisiona con otro objeto, en este caso, se va a hacer que al tocar al player lo elimina.
    void OnCollisionEnter(Collision collision)
    {
        // Se verifica si el objeto con el que colisionamos es el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destruye al jugador
            // Destroy(collision.gameObject);
            // Termina la ejecución de unity
            // UnityEditor.EditorApplication.isPlaying=false;
            // Me permite cambiar de escena
            SceneManager.LoadScene(2);

            // Escribe por consola que el jugador ha sido eliminado
            Debug.Log("El jugador ha sido eliminado. Has perdido el juego.");
        }
    }
}
