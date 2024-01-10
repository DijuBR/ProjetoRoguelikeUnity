using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaInimigo : MonoBehaviour
{
    public float vidaInimigoInicial;
    public float vidaInimigo, vidaIniMax;
    public GameObject explosao;
    public GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        vidaInimigo = vidaInimigoInicial + 1.30f * player.GetComponent<PlayerStatus>().dano + 0.3f - player.GetComponent<PlayerStatus>().fireRate;
        vidaIniMax = vidaInimigo;
    }
    
    void Update()
    {
        
        DanoInimigo();
    }
    public void DanoInimigo()
    {
        if (vidaInimigo <= 0)
        {
            Debug.Log("Morto Inimigo");
            Instantiate(explosao, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    
}
