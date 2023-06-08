using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroArmaPlayer : MonoBehaviour
{
    public float dano;
    public float delayTiro;
    public float velTiro;
    public float quantidadeTiro;
    public float disTiro;

    public Rigidbody2D rb;
    public GameObject inimigo;
    


    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inimigo = GameObject.FindGameObjectWithTag("Inimigo");
        rb.velocity = transform.right * velTiro;

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
