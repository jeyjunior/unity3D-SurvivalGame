using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{

    public NavMeshAgent inimigoNavMesh;
    public Transform playerPosition;
    
    public GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        inimigoNavMesh = GetComponent<NavMeshAgent>();
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();


    }

    // Update is called once per frame
    void Update()
    {
        inimigoNavMesh.destination = playerPosition.position;
    
         inimigoNavMesh.speed = gc.totalColetado;
    
    }
}
