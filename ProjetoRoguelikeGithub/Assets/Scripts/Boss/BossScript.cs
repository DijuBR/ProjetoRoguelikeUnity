using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    ControladorAudio audioManager;

    [Header("Referencias")]
    public scoreScript score;
    public GameObject particula;
    public Transform player;
    public bool Virado = false;
    public BoxCollider2D ParedeCol;
    public Animator anim;

    [Header("Variáveis Vida Boss")]
    public float vidaBossInicial;
    public float vidaBoss;
    public float vidaBossMax;
    public GameObject tiroBoss;
    public Transform tiroPos;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(player.position);
        Refs();
        AplicarVida();
        tiroPos = GameObject.FindWithTag("BossTiroPos").GetComponent<Transform>();

        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vidaBoss <= 0)
        {
            Morreu();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        col = ParedeCol;
        if (col.CompareTag("ChaoTileMap"))
        {
            Debug.Log("Virou");
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
            Virado = false;
        }
    }

    void Morreu()
    {
        Instantiate(particula, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    void AplicarVida()
    {
        score = GameObject.Find("Score").GetComponent<scoreScript>();
        vidaBoss = vidaBossInicial + +1.55f * (score.pontuacao);
        vidaBossMax = vidaBoss;
    }

    void Refs()
    {
        ParedeCol = GameObject.Find("ParedeCol").GetComponent<BoxCollider2D>();
    }
    void Evento()
    {
        audioManager.PlaySFX(audioManager.AtiraBoss);
        Instantiate(tiroBoss, tiroPos.transform);
    }
}
