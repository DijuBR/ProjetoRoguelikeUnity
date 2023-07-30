using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaInimigoTutorial : MonoBehaviour
{
    public float vidaInimigoInicial;
    public float vidaInimigo, vidaIniMax;
    public GameObject explosao;

    private void Start()
    {
        vidaInimigo = vidaInimigoInicial;
        vidaIniMax = vidaInimigo;
    }
    private void Awake()
    {

    }
    void Update()
    {
        DanoInimigo();
    }
    public void DanoInimigo()
    {
        if (vidaInimigo <= 0)
        {
            if (GameObject.Find("Spawner") == true)
            {
                GameObject.Find("Spawner").GetComponent<EnemySpawn>().inimigosnascidos -= 1;
                GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score++;
            }
            else if (GameObject.Find("SpawnerNoite") == true)
            {
                GameObject.Find("SpawnerNoite").GetComponent<EnemySpawn>().inimigosnascidos -= 1;
                GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score++;
            }
            else if (GameObject.Find("SpawnerTutorial") == true)
            {
                GameObject.Find("SpawnerTutorial").GetComponent<SpawnerTutorial>().inimigosnascidos -= 1;
                GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score++;
            }
            else
            {
                GameObject.Find("SpawnerTutorialFase").GetComponent<SpawnerTutorialFase>().inimigosnascidos -= 1;
                GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score++;
            }

            Debug.Log("Morto Inimigo");

            Instantiate(explosao, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
