using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public void Sair()
    {
        Application.Quit();
    }

    public void Reiniciar()
    {
        GameObject.Find("Main Camera").GetComponent<PlayerStatus>().Resetar();
        SceneManager.LoadScene("salaJogavel1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("TelaMenu");
    }
}
