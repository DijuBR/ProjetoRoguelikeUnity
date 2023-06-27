using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TiroArmaPlayer : MonoBehaviour
{
    public int dano;
    public float velTiro;
    public float quantidadeTiro;
    public float disTiro;
    public VidaInimigo VidaInimigo;


    public Rigidbody2D rb;
    public GameObject inimigo;
    private Transform tiroPlayerPos;
    
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        dano = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().dano;
        velTiro = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().velTiro;
        disTiro = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().disTiro;
        tiroPlayerPos = GameObject.FindGameObjectWithTag("TiroPlayerPos").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        inimigo = GameObject.FindGameObjectWithTag("Inimigo");
        rb.velocity = tiroPlayerPos.right * velTiro;

       
    }
    private void Update()
    {
         dano = PlayerPrefs.GetInt("DANO");
        velTiro = PlayerPrefs.GetFloat("VELTIRO");
        Destroy(this.gameObject, disTiro);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Inimigo")
        {
                Destroy(this.gameObject);
                Debug.Log(dano);
                col.GetComponent<VidaInimigo>().vidaInimigo -= dano;
        }
    }

    
}
