using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inimigo : MonoBehaviour
{
    public float moveX;
    public float moveY;
    private Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        Settings();
    }

    // Update is called once per frame
    void Update()
    {
        InimigoMovement();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("BarreiraX"))
        {
            moveX = moveX * -1;
            //transform.eulerAngles = new Vector2(0, 180);
            transform.Rotate(0, 180, 0);
        }

        if (col.gameObject.CompareTag("BarreiraY"))
        {
            //transform.eulerAngles = new Vector2(0, -180);
            moveX = moveX * -1;
            transform.Rotate(0, 180, 0);
        }

    }
    void InimigoMovement()
    {
        Vector2 movement = new Vector2(moveX, moveY);
        rb.MovePosition(rb.position + new Vector2(moveX, moveY));
    }

    void Settings()
    {
        rb = GetComponent<Rigidbody2D>();
    } 
}
