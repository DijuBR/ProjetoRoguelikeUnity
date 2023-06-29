using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float Horizontal;
    private Camera mainCam;
    private Transform playerTransform;
    private Rigidbody2D rb;
    
    public float velPlayer;
    public float forcaPulo;
    public double vida;
    private int pulos = 0;

    private void Start()
    {
        mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        playerTransform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        forcaPulo = PlayerPrefs.GetFloat("FORCPULO");
        velPlayer = PlayerPrefs.GetFloat("VELPLAYER");
        MovimentacaoDoPlayer();
        Virar();
    }

    private void Virar() //Virar o Player
    {
        Vector3 worldMousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        if (worldMousePos.x > transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (worldMousePos.x < transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
    public void MovimentacaoDoPlayer()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Horizontal * velPlayer, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && pulos > 0)
        {
            pulos--;
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo);

        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("ChaoTileMap"))
        {
            pulos = 1;
            Debug.Log("Pode Pular" + pulos);
        }
    }



}

