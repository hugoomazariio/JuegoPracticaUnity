using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f){
            Debug.Log("Voy al suelo");
        }
    }
}
