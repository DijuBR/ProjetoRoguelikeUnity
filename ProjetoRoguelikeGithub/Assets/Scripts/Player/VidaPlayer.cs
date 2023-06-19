using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public int vida;
    public int numCora;

    public Image[] coracao;
    public Sprite fullCora;
    public Sprite halfCora;
    public Sprite emptyCora;


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

        for (int i = 0; i < coracao.Length; i++)
        {

            if (vida == 1 || vida == 2 || vida == 3 || vida == 4 || vida == 5 || vida == 6)
            {
                coracao[i].sprite = fullCora;
            }
            else if (vida == 0.5 || vida == 1.5 || vida == 2.5 || vida == 3.5 || vida == 4.5 || vida == 5.5)
            {
                coracao[i].sprite = halfCora;
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
