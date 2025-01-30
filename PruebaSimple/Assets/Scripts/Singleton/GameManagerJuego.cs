using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerJuego : MonoBehaviour
{
    public Text ammoText;


    public static GameManagerJuego Instance { get; private set; }


    public int gunAmmo = 25;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        ammoText.text = gunAmmo.ToString();
    }
}
