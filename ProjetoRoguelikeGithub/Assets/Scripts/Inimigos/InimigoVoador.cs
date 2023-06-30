using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoVoador : MonoBehaviour
{
    private Transform player;
    private Transform pontoInicial;
    public float vel;
    public MonoBehaviour voadorAtirando;

    // Start is called before the first frame update
    void Start()
    {
        Settings();
    }

    // Update is called once per frame
    void Update()
    {
        Movimentar();
        Flipar();

    }

    void Movimentar()
    {
        float distanciaPlayer = Vector2.Distance(transform.position, player.transform.position);
        if(distanciaPlayer < 10)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, vel * Time.deltaTime);
            voadorAtirando.enabled = false;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, pontoInicial.transform.position, vel * Time.deltaTime);
            voadorAtirando.enabled = true;

        }
    }

    void Settings()
    {
        player = GameObject.Find("PlayerTeste").GetComponent<Transform>();
        pontoInicial = GameObject.Find("StartPoint").GetComponent<Transform>();
        voadorAtirando = GetComponent<AtirarInimigo>();
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
