using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
    private float Horizontal;
    private Camera mainCam;
    private Rigidbody2D rb;
    ControladorAudio audioManager;
    public ParticleSystem poeira;
    [Header("Movimenta��o e Vida")]
    public int pulos = 0;
    public float moveSpeed;
    public float jumpForce;
    public Animator animator;
    void Awake()
    {
        Setar();
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
        rb.velocity = new Vector2(Horizontal * moveSpeed, rb.velocity.y);
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
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        audioManager.PlaySFX(audioManager.Pulando);
    }
    void CriaPoeira()
    {
        poeira.Play();
    }
    void Setar()
    {
        jumpForce = PlayerPrefs.GetFloat("FORCPULO");
        moveSpeed = PlayerPrefs.GetFloat("VELPLAYER");
        mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }
}

