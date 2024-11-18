using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObjeto : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float thrust = 20f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.AddForce(0, 0, thrust, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(transform.up * thrust);
        }
    }
}

