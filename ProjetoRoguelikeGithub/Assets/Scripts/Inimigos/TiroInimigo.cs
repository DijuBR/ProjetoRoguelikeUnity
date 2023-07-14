using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private float timer;
    public GameObject explosao;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        MovimentoDoTiro();
    }

    // Update is called once per frame
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
            GameObject.Find("PlayerTeste").GetComponent<VidaPlayer>().Dano();
        }
        if (other.gameObject.CompareTag("ChaoTileMap"))
        {
            Instantiate(explosao, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("DomoTileMap"))
        {
            Instantiate(explosao, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    void MovimentoDoTiro()
    {
        Vector3 dir = player.transform.position - transform.position;
        rb.velocity = new Vector2(dir.x, dir.y).normalized * force;

        float rot = Mathf.Atan2(-dir.y, -dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }
    void TiroDestruir()
    {
        timer += Time.deltaTime;

        if (timer > 6)
        {
            Instantiate(explosao, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
