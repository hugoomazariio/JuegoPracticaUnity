using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform spawnPoint;

    public GameObject bullet;

    public float shotForce = 1500f; //Fuerza del disparo
    public float shotRate = 0.5f; //Cada 0.5 podemos disparar una bala

    private float shotRateTime = 0; //Tiempo que transcurre entre disparo y disparo


    void Update()
    {
        //fire1 es el click izqd del ratón
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shotRateTime && GameManagerJuego.Instance.gunAmmo > 0)
                // Ahora se tiene que cumplir que el GameManager sea mayor a 0 y podré disparar. Por eso, ahora tendré que ir reduciendo la munición.
            {
                GameManagerJuego.Instance.gunAmmo--; // Una unidad menos por cada vez que disparemos

                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                // Instancia un objeto (prefab en este caso) en una posición y con una rotación específica que le decimos

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotRateTime= Time.time + shotRate;

                Destroy(newBullet,2);
            }

        }
    }
}
