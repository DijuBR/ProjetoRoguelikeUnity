using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public double vida;
    public double numCora;

    public Image[] coracao;
    public Sprite fullCora;
    public Sprite halfCora;
    public Sprite emptyCora;

    private void Start()
    {
        vida = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().vida;
        numCora = vida;
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
        vida -= 0.5;
    }

    private void Update()
    {
        CoracoesCheck();
    }

    public void CoracoesCheck()
    {
        if (vida > numCora)
        {
            numCora = vida;
        }

        for (int i = 0; i < coracao.Length; i++)
        {
            if (i < vida)
            {
                coracao[i].sprite = fullCora;

                if (vida == i + 0.5)
                {
                    coracao[i].sprite = halfCora;
                }
            }
            else
            {
                coracao[i].sprite = emptyCora;
            }


            if (i < numCora)
            {
                coracao[i].enabled = true;
            }
            else
            {
                coracao[i].enabled = false;
            }
        }


    }
}
