using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoSeguidor : MonoBehaviour
{
    public Transform player;
    public float speed;
    private float distancia;

    // Start is called before the first frame update
    void Start()
    {
        Settings();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }



    void Movimento()
    {
        distancia = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
    void Settings()
    {
        player = GameObject.Find("PlayerTeste").GetComponent<Transform>();
    }
}
