using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TiroArmaPlayer : MonoBehaviour
{
    public float dano;
    public float delayTiro;
    public float velTiro;
    public float quantidadeTiro;
    public float disTiro;

    public Rigidbody2D rb;
    public GameObject inimigo;
    private Transform tiroPlayerPos;
    


    
    // Start is called before the first frame update
    void Start()
    {
        tiroPlayerPos = GameObject.FindGameObjectWithTag("TiroPlayerPos").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        inimigo = GameObject.FindGameObjectWithTag("Inimigo");
        rb.velocity = tiroPlayerPos.right * velTiro;

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Inimigo"))
        {
            Destroy(this.gameObject);

            GameObject.Find("Inimigo").GetComponent<Inimigo>().DanoInimigo();
        }
    }



}
