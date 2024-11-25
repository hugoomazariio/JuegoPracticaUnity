using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public Transform player; //Declaramos nuestro transform player, para sacar la posición de nuestro personaje
    private NavMeshAgent navMeshAgent; //Declaramos un agente
    private Animator anim; //Declaramos un animator que es el gestor del movimiento de nuestra IA

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim= GetComponentInChildren<Animator>(); //El hijo es el que tiene el animator, el padre no lo tiene, así busca fácilmente al hijo
        if (anim)
        {
            anim.SetFloat("speed_f", navMeshAgent.speed); //Velocidad
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            navMeshAgent.SetDestination(player.position); //Esto hace que vaya hacía el personaje, de forma autónoma usa la malla de navegación(sitio por el que puede moverse)
        }
    }
}
