using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simpleray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction);   
        RaycastHit hit;

        //Si el rayo golpea algo
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Golpeó: " + hit.collider.name);
        }
    }
}
