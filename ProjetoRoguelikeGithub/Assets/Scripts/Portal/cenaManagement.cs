using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cenaManagement : MonoBehaviour
{
    private List<int> cenas = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

    public void NextScene()
    {
        int randomIndex = Random.Range(0, cenas.Count);
        int cenaAtual = cenas[randomIndex];
        GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao++;
        GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score++;
        SceneManager.LoadScene(cenaAtual);
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("TutorialFase");
    }

    public void Boss()
    {
        SceneManager.LoadScene("SalaDoBoss");
    }
}


