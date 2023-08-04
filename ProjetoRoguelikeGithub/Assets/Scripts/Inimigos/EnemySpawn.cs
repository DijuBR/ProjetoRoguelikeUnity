using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform pos;
    public int inimigosnascidos;

    void Spawn()
    {
        int randomEnemy = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[randomEnemy],
            new Vector3(Random.Range(pos.position.x - 2f, pos.position.x + 2f),
            Random.Range(pos.position.y - 2f, pos.position.y + 2f), 0),
            Quaternion.identity);
    }

    public void Start()
    {
        int spawn = 0;
        int spawnMax = 0;

        if(GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score >= 0 && GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score <= 5)
        {
            spawn = Random.Range(2, 4);
            Debug.Log("If 1");
        }else if(GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score >= 6 && GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score <= 10)
        {
            spawn = Random.Range(4, 6);
            Debug.Log("If 2");
        }

        while (spawnMax != spawn)
        {
            spawnMax++;
            Spawn();
            inimigosnascidos = spawnMax;
            Debug.Log(spawnMax);
        }
    }
}
