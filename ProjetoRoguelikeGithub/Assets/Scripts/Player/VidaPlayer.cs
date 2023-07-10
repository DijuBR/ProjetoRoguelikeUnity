using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaPlayer : MonoBehaviour
{
    [Header("VIDA")]
    public double vida;
    public double numCora;

    public Image[] coracao;
    public Sprite fullCora;
    public Sprite halfCora;
    public Sprite emptyCora;
    [Header("Frames De Imortalidade")]
    public bool estaImortal = false;
    [SerializeField]private float tempoImortal;

    private void Start()
    {
        vida = PlayerPrefs.GetFloat("VIDA");
        numCora = vida;
    }

    private void OnCollisionStay2D(Collision2D col2)
    {
       if (col2.gameObject.CompareTag("Inimigo"))
       {
        Dano();
       }
    }
    public void Dano()
    {
        if(estaImortal == false)
        {
            vida -= 0.5;
            GetComponent<FlashDano>().FlashRun();
            StartCoroutine("TempImortal");
        }
        
    }

    private void Update()
    {
        CoracoesCheck();
        Morreu();
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

    void Morreu()
    {
        if(vida <= 0)
        {
            SceneManager.LoadScene("MenuGameOver");
        }
    }

    private IEnumerator TempImortal()
    {
        estaImortal = true;
        Debug.Log("Player Imortal: " + estaImortal);

        yield return new WaitForSeconds(tempoImortal);

        estaImortal = false;
        Debug.Log("Player Imortal: " + estaImortal);



    }
    
}
