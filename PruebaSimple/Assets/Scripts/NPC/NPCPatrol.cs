using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPatrol : MonoBehaviour
{
    public Transform[] waypoints; //Array de transforms

    public float velocidad = 3f; //Velocidad de movimiento

    private int posicion = 0; // posicion del npc


    private UnityEngine.AI.NavMeshAgent navMeshAgent;


    void Start()
    {
        // Si no se usa un NavMeshAgent, se usará un movimiento directo
        if (navMeshAgent != null)
        {
            navMeshAgent.speed = velocidad;
        }
    }


    void Update()
    {
        // Verifica que haya waypoints
        if (waypoints.Length == 0)
            return;


        // Si el NPC ha llegado al waypoint actual se moverá al siguiente waypoint
        if (navMeshAgent != null && !navMeshAgent.pathPending && navMeshAgent.remainingDistance < 0.5f)
        {
            // Mueve al siguiente punto de patrullaje
            GoToNextPoint();
        }
        else if (navMeshAgent == null)
        {
            // Movimiento sin NavMeshAgent (si no se está utilizando navegación)
            MoveToNextPoint();
        }
    }


    void GoToNextPoint()
    {
        // Incrementa el índice y hacer que vuelva a empezar cuando alcance el último punto
        posicion = (posicion + 1) % waypoints.Length;


        // Moverse al siguiente punto de patrullaje
        navMeshAgent.SetDestination(waypoints[posicion].position);
    }


    void MoveToNextPoint()
    {
        // Obtener el siguiente waypoint
        Transform target = waypoints[posicion];


        // Mover al NPC hacia el siguiente punto (sin NavMeshAgent)
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * velocidad * Time.deltaTime, Space.World);


        // Comprobar si el NPC ha llegado al waypoint
        if (Vector3.Distance(transform.position, target.position) < 0.2f)
        {
            // Avanzar al siguiente waypoint
            posicion = (posicion + 1) % waypoints.Length;
        }
    }
}

