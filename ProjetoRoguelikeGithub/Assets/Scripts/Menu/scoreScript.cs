using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public float pontuacao;

    private void Start()
    {
        
    }

    void Update()
    {
        pontuacao = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao;
    }
}
