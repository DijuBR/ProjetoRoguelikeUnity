using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using JetBrains.Annotations;
using System.Threading;

public class PlayerMovement : MonoBehaviour
{
    //Variavéis para movimentação do player, tudo que for PUBLIC altere o valor na Unity!
    //Não mude nada, por favor.
    //Um dos projetos já feitos
    private float Horizontal;
    private Camera mainCam;
    private Transform playerTransform;
    Vector2 mousePos;

    public float velPlayer;
    public float forcaPulo;

    private bool virDireita = true;


    public double vida;
    public double numCora;

    public Image[] coracao;
    public Sprite fullCora;
    public Sprite halfCora;
    public Sprite emptyCora;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private void Start()
    {
        forcaPulo = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().forcPulo;
        velPlayer = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().velPlayer;
        vida = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().vida;
        numCora = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().numCora;
        mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        numCora = vida;
        playerTransform = GetComponent<Transform>();
    }

    public void Update()
    {
        MovimentacaoDoPlayer();
        CoracoesCheck();
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

    private bool noChao()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void OnCollisionEnter2D(Collision2D col2)
    {

        if (col2.gameObject.CompareTag("Inimigo"))
        {
            Dano();
        }
    }

    public void Dano()
    {
        vida -= 0.5;
    }

    public void CoracoesCheck()
    {
        if (vida > numCora)
        {
            numCora = vida;
        }

        for (int i = 0; i < coracao.Length; i++)
        {
            if (i < vida)
            {
                coracao[i].sprite = fullCora;

                if (vida == i + 0.5)
                {
                    coracao[i].sprite = halfCora;
                }
            }
            else
            {
                coracao[i].sprite = emptyCora;
            }


            if (i < numCora)
            {
                coracao[i].enabled = true;
            }
            else
            {
                coracao[i].enabled = false;
            }
        }


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

