using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public TextMeshProUGUI textoScore;
    public int pontuacao;

    // Start is called before the first frame update
    private void Start()
    {
        pontuacao = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao;
    }

    void Update()
    {
        textoScore.text = "Score: " + pontuacao;
    }
}
