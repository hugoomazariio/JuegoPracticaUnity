using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider slider; 
    public float sliderValue;
    public Image imagenMute;


    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f); // Crea un valor para que guarde la posición donde se ha quedado el slider
        AudioListener.volume = slider.value; // Sacamos el volumen de nuestro juego, tiene el valor del slider value(va de 0 a 1)
        RevisarSiEstoyMute();
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue); // Ponemos un valor
        AudioListener.volume = slider.value; // Este va a ser el valor que queremos del slider value y despues entra al método
        RevisarSiEstoyMute();
    }

    public void RevisarSiEstoyMute() // Revisa si el volumen está en 0
    {
        if (sliderValue == 0)
            imagenMute.enabled = true;
        else
            imagenMute.enabled = false;
    }
}

