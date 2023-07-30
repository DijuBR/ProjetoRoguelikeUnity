using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public float score;
    public TextMeshPro texto;

    private void Start()
    {
        texto = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        score = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score;
        texto.text = "Score: " + score.ToString();
    }
}
