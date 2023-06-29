using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaInimigo : MonoBehaviour
{
    public float vidaInimigo;
    
    void Update()
    {
        DanoInimigo();
    }
    public void DanoInimigo()
    {
        if (vidaInimigo <= 0)
        {
            //GameObject.Find("BG").GetComponent<PassarFase>().inimigomorto++;
            GameObject.Find("Spawner").GetComponent<EnemySpawn>().inimigosnascidos -= 1;
            Debug.Log("Morto Inimigo");
            Destroy(gameObject);
        }
    }
}
