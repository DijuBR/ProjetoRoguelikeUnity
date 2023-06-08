using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoVoador : MonoBehaviour
{
    public Transform player;
    public Transform pontoInicial;
    public float vel;
    public MonoBehaviour voadorAtirando;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimentar();
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
}
