using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Codigo_Pausa : MonoBehaviour
{
    public GameObject ObjetoMenuPausa;
    public bool Pausa = false;
    public GameObject MenuSalir;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (Pausa == false) {
                ObjetoMenuPausa.SetActive(true);
                Pausa = true;

                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else if(Pausa == false)
            {
                Resumir();
            }
        }
    }

    public void Resumir()
    {
        ObjetoMenuPausa.SetActive(false);
        MenuSalir.SetActive(false);
        Pausa=false;

        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;   
    }

    public void irAlMenu(string NombreMenu)
    {
        SceneManager.LoadScene(NombreMenu);
    }
    public void salirDelJuego()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit(); // Esto solo va a funcionar cuando el juego esté exportado, ejecutándolo en Unity no funcionará
        // UnityEditor.EditorApplication.isPlaying = false; // Va a terminar la ejecución del programa en el editor.
    }
}
