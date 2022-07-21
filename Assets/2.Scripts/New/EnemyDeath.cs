
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int EnemyHealth = 20;
    public GameObject enemy;
    public int statusCheck;

     void DamageEnemy (int DamageAmount)
     {
        EnemyHealth -= DamageAmount;
     }
    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0 && statusCheck == 0)
        {
            statusCheck = 2;
            enemy.GetComponent<Animation>().Stop("Walking");
            enemy.GetComponent<Animation>().Play("Death");

        }
    }
}
