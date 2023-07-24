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

    ControladorAudio audioManager;

    public ParticleSystem poeira;
    
    [Header("Movimentação e Vida")]
    public float velPlayer;
    public float forcaPulo;
    public double vida;
    public int pulos = 0;

    public Animator animator;

    private bool virado = true;

    private void Start()
    {
        mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        playerTransform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    public void Update()
    {
        forcaPulo = PlayerPrefs.GetFloat("FORCPULO");
        velPlayer = PlayerPrefs.GetFloat("VELPLAYER");
    }

    private void Virar() //Virar o Player
    {
        Vector3 worldMousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        if (worldMousePos.x > transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            virado = true;
            
        }
        if (worldMousePos.x < transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            virado = false;
            
        }
    }
    public void MovimentacaoDoPlayer()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Horizontal * velPlayer, rb.velocity.y);

        

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
        rb.velocity = new Vector2(rb.velocity.x, forcaPulo);
        audioManager.PlaySFX(audioManager.Pulando);
    }

    void CriaPoeira()
    {
        poeira.Play();
    }

}

