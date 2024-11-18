using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayocubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction* 30f);
    }
}
