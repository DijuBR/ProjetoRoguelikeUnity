using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoSeguidor : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    private float distancia;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }



    void Movimento()
    {
        distancia = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
    }
}
