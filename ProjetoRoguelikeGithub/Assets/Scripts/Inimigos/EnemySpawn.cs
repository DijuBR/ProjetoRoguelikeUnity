using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform pos;
    public int inimigosnascidos;
    private int spawn;
    public int contador;

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
        contador = PlayerPrefs.GetInt("contador");
        int spawnMax = 0;
        Debug.Log("Contador:" + contador);
        if(contador <= 1)
        {
            spawn = Random.Range(2, 4);
            Debug.Log("If 1");
        }
        if(contador >= 2)
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

    private void Update()
    {
        PlayerPrefs.GetInt("contador", contador);
    }
}
