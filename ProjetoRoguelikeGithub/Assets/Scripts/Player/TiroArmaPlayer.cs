using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TiroArmaPlayer : MonoBehaviour
{
    public float dano;
    public float velTiro;
    public float quantidadeTiro;
    public float disTiro;
    public VidaInimigo VidaInimigo;

    public GameObject explosao;


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
         dano = PlayerPrefs.GetFloat("DANO");
        velTiro = PlayerPrefs.GetFloat("VELTIRO");
        Destroy(this.gameObject, disTiro);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Inimigo")
        {
                Destroy(this.gameObject);
                col.GetComponent<FlashDano>().FlashRun();
                Debug.Log(dano);
            if(col.GetComponent<VidaInimigo>() == true)
            {
                col.GetComponent<VidaInimigo>().vidaInimigo -= dano;
            }
            else
            {
                col.GetComponent<BossScript>().vidaBoss -= dano;
            }
            //col.GetComponent<VidaInimigo>().vidaInimigo -= dano;
        }
        if (col.gameObject.CompareTag("ChaoTileMap"))
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.CompareTag("DomoTileMap"))
        {
            Destroy(this.gameObject);
        }
        if (col.CompareTag("InimigoTutorial"))
        {
            Destroy(this.gameObject);
            col.GetComponent<FlashDano>().FlashRun();
            Debug.Log(dano);
            col.GetComponent<VidaInimigoTutorial>().vidaInimigo -= dano;
        }
    }

    private void OnDestroy()
    {
        Instantiate(explosao, transform.position, Quaternion.identity);
    }

}
