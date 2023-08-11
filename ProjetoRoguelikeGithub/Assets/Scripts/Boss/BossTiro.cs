using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTiro : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float speed;
    private float timer;
    public GameObject explosao;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        MovimentoDoTiro();
    }

    void Update()
    {
        TiroDestruir();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(explosao, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            GameObject.Find("PlayerTeste").GetComponent<VidaPlayer>().DanoBoss();
        }
        if (other.gameObject.CompareTag("DomoTileMap") || other.gameObject.CompareTag("ChaoTileMap"))
        {
            MovimentoDoTiro();
            speed -= 0.90f;
        }
    }
    void MovimentoDoTiro()
    {
        Vector3 dir = player.transform.position - transform.position;
        rb.velocity = new Vector2(dir.x, dir.y).normalized * speed;

        float rot = Mathf.Atan2(-dir.y, -dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }
    void TiroDestruir()
    {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            Instantiate(explosao, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }
}
