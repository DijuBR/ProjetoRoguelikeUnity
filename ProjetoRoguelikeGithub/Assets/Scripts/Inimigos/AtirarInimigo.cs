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

    ControladorAudio audioManager;

    // Start is called before the first frame update
    void Start()
    {
        Settings();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

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
            audioManager.PlaySFX(audioManager.Atirainimigo);
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
