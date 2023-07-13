using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaInimigo : MonoBehaviour
{
    public float vidaInimigoInicial;
    public float vidaInimigo, vidaIniMax;
    public scoreScript score;

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
            else
            {
                GameObject.Find("SpawnerNoite").GetComponent<EnemySpawn>().inimigosnascidos -= 1;
            }
            
            Debug.Log("Morto Inimigo");
            Destroy(gameObject);
        }
    }
    
}
