using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarInimigo : MonoBehaviour
{
    public GameObject Tiro;
    public Transform TiroPos;

    public bool Voador;
    public bool Atirando = false;

    public float dist;
    private float timer;
    private GameObject player;

    public float delayTiroIni;
    private float tiroInimCD = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistancia();
        CheckDistanciaVoador();
    }
    void Atirar()
    {
        if (Time.time > tiroInimCD)
        {
            tiroInimCD = Time.time + delayTiroIni;
            Instantiate(Tiro, TiroPos.position, Quaternion.identity);
        }
        
    }
    void CheckDistancia()
    {
        float distancia = Vector2.Distance(transform.position, player.transform.position); 

        if(distancia < dist)
        {
            Atirar();
        }
    }
    void CheckDistanciaVoador()
    {
        
        float distancia = Vector2.Distance(transform.position, player.transform.position);
            if(distancia > dist)
            {
                Atirar();
            }
        
       
    }
}
