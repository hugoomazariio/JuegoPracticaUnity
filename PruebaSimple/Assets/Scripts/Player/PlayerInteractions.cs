using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GunAmmo"))
        {
            GameManagerJuego.Instance.gunAmmo += other.gameObject.GetComponent<AmmoBox>().ammo;
            // Vamos a acceder al GameManager y se suma la munición de la caja. Es posible porque la caja tiene la etiqueta de gunAmmo. 
            // Si cojo la caja tendré 50 más de munición

            Destroy(other.gameObject);
        }
    }
} 
