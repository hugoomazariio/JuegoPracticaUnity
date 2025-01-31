using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManagerJuego : MonoBehaviour
{
    public TMP_Text ammoText; 
    public static GameManagerJuego Instance { get; private set; }
    public int gunAmmo = 25;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (ammoText != null)
        {
            ammoText.text = gunAmmo.ToString();
        }
        else
        {
            Debug.LogError("El componente TextMeshPro no ha sido asignado.");
        }
    }
}