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
        Settings();
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistancia();
        CheckDistanciaVoador();
        Flipar();
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

    void Settings()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Flipar()
    {
        if (transform.position.x < player.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (transform.position.x > player.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
