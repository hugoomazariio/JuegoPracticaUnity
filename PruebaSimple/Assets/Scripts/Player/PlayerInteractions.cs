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
            // Vamos a acceder al GameManager y se suma la munici�n de la caja. Es posible porque la caja tiene la etiqueta de gunAmmo. 
            // Si cojo la caja tendr� 50 m�s de munici�n

            Destroy(other.gameObject);
        }
    }
} 
