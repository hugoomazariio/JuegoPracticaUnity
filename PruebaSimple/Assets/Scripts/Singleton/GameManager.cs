using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } // Singleton
    private bool isSceneChangeRequested = false; // Variable para registrar si se ha solicitado un cambio de escena

    private void Awake()
    // Awake es un método de MonoBehaviour que se ejecuta una sola vez cuando se instancia al objeto.                 
    // Implementa el Singleton asegurándose de que solo exista una única instancia del gameManager.           
    // Se hace persistente entre escenas con DontDestroyOnLoad(gameObject) evitando que se destruya al cambiar de escena.

    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantiene el GameManager entre escenas
        }
        else
        {
            Destroy(gameObject); // Si ya hay un GameManager, destruye este duplicado
            return; // Salir del método Awake para evitar más ejecuciones
        }

        // Si no estamos en el menú y no se ha solicitado un cambio de escena, cargamos el menú
        if (SceneManager.GetActiveScene().buildIndex != 0 && !isSceneChangeRequested)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void CargarMenu()
    {
        isSceneChangeRequested = true; // Marcar que se ha solicitado un cambio de escena
        SceneManager.LoadScene(0); // Asegúrate de que el índice del menú es correcto
    }

    public void CargarJuego()
    {
        isSceneChangeRequested = true; // Marcar que se ha solicitado un cambio de escena
        SceneManager.LoadScene(1); // Cambia al índice de la escena del juego
    }

    public void CargarGameOver()
    {
        isSceneChangeRequested = true; // Marcar que se ha solicitado un cambio de escena
        SceneManager.LoadScene(2); // Cambia al índice de Game Over

        // Se asegura que el cursor esté visible cuando el jugador pierda
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego...");
        // Application.Quit(); // Esto solo va a funcionar cuando el juego esté exportado, ejecutándolo en Unity no funcionará
        UnityEditor.EditorApplication.isPlaying = false; // Va a terminar la ejecución del programa en el editor.
    }
}