using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 dir = player.transform.position - transform.position;
        rb.velocity = new Vector2(dir.x, dir.y).normalized * force;

        float rot = Mathf.Atan2(-dir.y, -dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0 ,rot);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer > 6)
        {
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            GameObject.Find("PlayerTeste").GetComponent<PlayerMovement>().Dano();
        }
    }
}