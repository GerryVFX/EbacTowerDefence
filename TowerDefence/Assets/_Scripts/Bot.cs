using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    [SerializeField] Transform enemyTarget;
    [SerializeField] GameObject objetive;
    Animator animController;
    public int life = 100;
    void Start()
    {
        animController = GetComponent<Animator>();
        GetComponent<NavMeshAgent>().SetDestination(enemyTarget.position);
        animController.SetBool("Walk", true);
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyTarget"))
        {
            animController.SetBool("Walk", false);
            animController.SetBool("Attack", true);
        }
    }

    public void DoDamage()
    {
        objetive?.GetComponent<EnemyTarget>().TakeDamage(40);
    }

    public void TakeDamage(int damage = 5)
    {
        life -= damage;
    }
}
