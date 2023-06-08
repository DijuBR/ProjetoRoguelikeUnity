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
        Instantiate(Tiro, TiroPos.position, Quaternion.identity);
    }
    void CheckDistancia()
    {
        timer += Time.deltaTime;
        float distancia = Vector2.Distance(transform.position, player.transform.position);

        if (distancia < dist)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                timer = 0;
                Atirar();
            }

        }
    }
    void CheckDistanciaVoador()
    {
        timer += Time.deltaTime;
        float distancia = Vector2.Distance(transform.position, player.transform.position);
            if(distancia > dist)
            {
                timer += Time.deltaTime;
                if (timer > 2)
                {
                    timer = 0;
                    Atirar();
                }

            }
        
       
    }
}
