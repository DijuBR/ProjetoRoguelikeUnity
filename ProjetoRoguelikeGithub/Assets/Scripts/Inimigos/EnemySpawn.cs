using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform pos;
    public int inimigosnascidos;
    [SerializeField] private int spawn;

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
        spawn = PlayerPrefs.GetInt("spawn");
        int spawnMax = 0;

        while (spawnMax != spawn)
        {
            spawnMax++;
            Spawn();
            inimigosnascidos = spawnMax;
            Debug.Log(spawnMax);
        }
    }
}