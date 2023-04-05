using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public int life = 100;
    void Update()
    {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage = 20)
    {
        life -= damage;
    }
}
