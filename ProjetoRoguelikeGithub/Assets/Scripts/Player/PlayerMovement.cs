using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
    private float Horizontal;
    private Camera mainCam;
    private Transform playerTransform;
    private Rigidbody2D rb;
    public Stats sSPlayer;
    ControladorAudio audioManager;
    public ParticleSystem poeira;
    [Header("Movimenta��o e Vida")]
    public int pulos = 0;
    public Animator animator;



    private void Start()
    {
        mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    public void Update()
    {
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
        rb.velocity = new Vector2(Horizontal * sSPlayer.moveSpeed, rb.velocity.y);

        if (Mathf.Abs(Horizontal) > 0)
        {
            CriaPoeira();
        }

        animator.SetFloat("Speed", Mathf.Abs(Horizontal));

        if (Input.GetButtonDown("Jump") && pulos > 0)
        {
            Pular();
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    public void Pular()
    {
        pulos--;
        rb.velocity = new Vector2(rb.velocity.x, sSPlayer.jumpForce);
        audioManager.PlaySFX(audioManager.Pulando);
    }

    void CriaPoeira()
    {
        poeira.Play();
    }

}

