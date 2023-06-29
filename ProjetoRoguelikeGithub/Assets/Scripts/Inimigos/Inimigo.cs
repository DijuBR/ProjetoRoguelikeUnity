using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inimigo : MonoBehaviour
{
    public float moveX;
    
    private Rigidbody2D rb;
    public GameObject pontoA;
    public GameObject pontoB;
    private Transform pontoAtual;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pontoAtual = pontoB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //InimigoMovement();

        Vector2 ponto = pontoAtual.position - transform.position;

        if(pontoAtual == pontoB.transform)
        {
            rb.velocity = new Vector2(moveX, transform.position.y);
        }
        else
        {
            rb.velocity = new Vector2(-moveX, transform.position.y);
        }

        if (Vector2.Distance(transform.position, pontoAtual.position) < 0.5f && pontoAtual == pontoB.transform)
        {
            pontoAtual = pontoA.transform;
            ViraInimigo();
        }

        if (Vector2.Distance(transform.position, pontoAtual.position) < 0.5f && pontoAtual == pontoA.transform)
        {
            pontoAtual = pontoB.transform;
            ViraInimigo();
        }
    }

    private void ViraInimigo()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }





    //private void OnCollisionEnter2D(Collision2D col)
    //{
    //    if (col.gameObject.CompareTag("BarreiraX"))
    //    {
    //        moveX = moveX * -1;
    //        moveY = moveX;
    //        //transform.eulerAngles = new Vector2(0, 180);
    //        transform.Rotate(0, 180, 0);
    //    }

    //    if (col.gameObject.CompareTag("BarreiraY"))
    //    {
    //        //transform.eulerAngles = new Vector2(0, -180);
    //        moveX = moveX * -1;
    //        moveY = moveX;
    //        transform.Rotate(0, 180, 0);
    //    }

    //}

    //void InimigoMovement()
    //{
    //    Vector2 movement = new Vector2(moveX, moveY);
    //    rb.MovePosition(new Vector2(moveX, moveY));
    //}
}
