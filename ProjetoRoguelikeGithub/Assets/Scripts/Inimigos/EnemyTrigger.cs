using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public EnemyFly[] enemyArray;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            foreach(EnemyFly enemy in enemyArray)
            {
                enemy.perseguir = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            foreach (EnemyFly enemy in enemyArray)
            {
                enemy.perseguir = false;
            }
        }
    }
}
