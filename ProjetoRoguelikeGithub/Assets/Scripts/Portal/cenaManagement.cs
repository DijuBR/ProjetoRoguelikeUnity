using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cenaManagement : MonoBehaviour
{

    private List<int> cenas = new List<int> { 1, 2, 3, 4, 5, 6 };

    public void NextScene()
    {
        int randomIndex = Random.Range(0, cenas.Count);

        int cenaAtual = cenas[randomIndex];
        GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao++;
        SceneManager.LoadScene(cenaAtual);
    }
}


