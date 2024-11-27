using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminatePlayer : MonoBehaviour
{

    // Este método se llama cuando el enemigo colisiona con otro objeto, en este caso, se va a hacer que al tocar al player lo elimina.
    void OnCollisionEnter(Collision collision)
    {
        // Se verifica si el objeto con el que colisionamos es el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destruye al jugador
            Destroy(collision.gameObject);
            //Termina la ejecución de unity
            UnityEditor.EditorApplication.isPlaying=false;

            // Escribe por consola que el jugador ha sido eliminado
            Debug.Log("El jugador ha sido eliminado. Has perdido el juego.");
        }
    }
}
