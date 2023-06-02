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
    public float VelPlayer; 
    public float forcaPulo;
    private bool virDireita;
    public int vida = 3;

    public float KBforce;
    public float KBcontador;
    public float KBTempototal;
    public bool KBlado;



    [SerializeField] Image vidaOn3;
    [SerializeField] Image vidaOff3;

    [SerializeField] Image vidaOn2;
    [SerializeField] Image vidaOff2;




    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

private void Update()
{
 Horizontal = Input.GetAxisRaw("Horizontal");

 if (Input.GetButtonDown("Jump") && noChao())
 {
    rb.velocity = new Vector2(rb.velocity.x, forcaPulo);

 }
 if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
 {
    rb.velocity = new Vector2(rb.velocity.x , rb.velocity.y * 0.5f);
 }

  Virar();

}

private void FixedUpdate()
{

        if (KBcontador <= 0)
        {
            rb.velocity = new Vector2(Horizontal * VelPlayer, rb.velocity.y);
        }
        else
        {
            if (KBlado == true)
            {
                rb.velocity = new Vector2(-KBforce, KBforce);
            }
            if (KBlado == false)
            {
                rb.velocity = new Vector2(KBforce, KBforce);
            }

            KBcontador -= Time.deltaTime;
        }
        
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

    private void OnCollisionEnter2D(Collision2D col2)
    {

        if (col2.gameObject.CompareTag("Inimigo"))
        {
            Dano();
        }
    }

    public void Dano()
    {
        vida -= 1;

        if (vida == 2)
        {
            vidaOff3.enabled = true;
            vidaOn3.enabled = false;
            vidaOn2.enabled = true;
            vidaOff2.enabled = false;
            

        }
        if (vida == 1)
        {
            vidaOff3.enabled = true;
            vidaOn3.enabled = false;
            vidaOn2.enabled = false;
            vidaOff2.enabled = true;

        }

        if (vida < 1)
        {
            Debug.Log("Morreu");
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

    
}

