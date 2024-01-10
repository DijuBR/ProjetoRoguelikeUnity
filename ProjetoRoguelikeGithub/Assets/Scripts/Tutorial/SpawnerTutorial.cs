using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTutorial : MonoBehaviour
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
    private void Start()
    {
        int spawn = Random.Range(1, 2);
        int spawnMax = 0;

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
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {

        }
    }
}
