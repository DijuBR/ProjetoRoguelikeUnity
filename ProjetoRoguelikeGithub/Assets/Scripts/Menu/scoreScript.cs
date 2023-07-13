using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public float pontuacao;
    public TextMeshPro texto;

    private void Start()
    {
        texto = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        pontuacao = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao;
        texto.text =  "Score: " + pontuacao.ToString();
    }
}
