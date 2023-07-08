using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoSeguidor : MonoBehaviour
{
    public Transform player;
    public float speed;
    private float distancia;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Settings();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();

        if(transform.position.x < player.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (transform.position.x > player.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }



    void Movimento()
    {
        distancia = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        animator.SetFloat("Speed", Mathf.Abs(distancia));
    }
    void Settings()
    {
        player = GameObject.Find("PlayerTeste").GetComponent<Transform>();
    }
}
