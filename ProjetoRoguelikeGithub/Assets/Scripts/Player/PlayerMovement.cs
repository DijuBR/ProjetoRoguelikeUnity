using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //Variavéis para movimentação do player, tudo que for PUBLIC altere o valor na Unity!
    //Não mude nada, por favor.
    //Um dos projetos já feitos
    private float Horizontal;
    
    public float velPlayer;
    public float forcaPulo;

    private bool virDireita;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private void Start()
    {
        forcaPulo = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().forcPulo;
        velPlayer = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().velPlayer;
    }
    private void Update()
    {
        MovimentacaoDoPlayer();
        Virar();

    }
    private void Virar() //Virar o Player
    {
        if (virDireita && Horizontal < 0f || virDireita && Horizontal > 0f)
        {
        virDireita = !virDireita;
        Vector3 localScale = transform.localScale;
        localScale.x = -1f;
        transform.localScale = localScale;
        }
    }

    private bool noChao()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("ObjectDano"))
        {
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo);
        }

        if (col.CompareTag("Inimigo"))
        {
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo);
        }
    }
    
    public void MovimentacaoDoPlayer()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Horizontal * velPlayer, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && noChao())
        {
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo);

        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

    }

}

