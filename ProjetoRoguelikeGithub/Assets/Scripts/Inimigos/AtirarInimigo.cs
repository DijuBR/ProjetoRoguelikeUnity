using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarInimigo : MonoBehaviour
{
    public GameObject Tiro;
    public Transform TiroPos;

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
        timer += Time.deltaTime;
        float distancia = Vector2.Distance(transform.position, player.transform.position);

        if(distancia < 10)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                timer = 0;
                Atirar();
            }

        }

        
    }
    void Atirar()
    {
        Instantiate(Tiro, TiroPos.position, Quaternion.identity);
    }
}
