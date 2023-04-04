using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    [SerializeField] Transform enemyTarget;
    Animator animController;
    void Start()
    {
        animController = GetComponent<Animator>();
        GetComponent<NavMeshAgent>().SetDestination(enemyTarget.position);
        animController.SetBool("Walk", true);
    }

    void Update()
    {
        
    }
}
