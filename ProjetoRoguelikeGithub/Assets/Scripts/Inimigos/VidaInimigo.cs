using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaInimigo : MonoBehaviour
{
    public float vidaInimigoInicial;
    public float vidaInimigo, vidaIniMax;
    public scoreScript score;
    public GameObject explosao;

    private void Start()
    {
        score = GameObject.Find("Score").GetComponent<scoreScript>();
        vidaInimigo = vidaInimigoInicial + 1.35f*(score.pontuacao);
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
            if(GameObject.Find("Spawner") == true)
            {
                GameObject.Find("Spawner").GetComponent<EnemySpawn>().inimigosnascidos -= 1;
            }
            else if (GameObject.Find("SpawnerNoite") == true)
            {
                GameObject.Find("SpawnerNoite").GetComponent<EnemySpawn>().inimigosnascidos -= 1;
            }
            else if (GameObject.Find("SpawnerTutorial") == true)
            {
                GameObject.Find("SpawnerTutorial").GetComponent<SpawnerTutorial>().inimigosnascidos -= 1;
            }
            else
            {
                GameObject.Find("SpawnerTutorialFase").GetComponent<SpawnerTutorialFase>().inimigosnascidos -= 1;
            }
            
            Debug.Log("Morto Inimigo");

            Instantiate(explosao, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
    
}
