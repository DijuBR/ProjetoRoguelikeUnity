using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public GameObject[] enemyPrefabs;
    public Transform pos;
    public int inimigosnascidos;

    private int spawn;
    public int addSpawn;

    void Spawn()
    {
        int randomEnemy = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[randomEnemy],
            new Vector3(Random.Range(pos.position.x - 2f, pos.position.x + 2f),
            Random.Range(pos.position.y - 2f, pos.position.y + 2f), 0),
            Quaternion.identity);
    } 

    void acrescentaSpawn()
    {
        if (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score > 0 && GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score < 5)
        {
            addSpawn = Random.Range(1, 2);
        }

        if (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score >= 5 && GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score < 13)
        {
            addSpawn = Random.Range(2, 4);
        }

        if (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score >= 13)
        {
            addSpawn = Random.Range(3, 5);
        }
    }

    private void Start()
    {
        acrescentaSpawn();
        spawn = Random.Range(2, 4) + addSpawn;
        int spawnMax = 0;

        while(spawnMax != spawn)
        {
            spawnMax++;
            Spawn();
            inimigosnascidos = spawnMax;
            Debug.Log(spawnMax);
        }
    }

    private void Update()
    {
        
    }
}
