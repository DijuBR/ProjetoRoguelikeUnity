using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    ControladorAudio audioManager;

    public void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    public void Sair()
    {
        audioManager.PlaySFX(audioManager.Botoes);
        Application.Quit();
    }

    public void Reiniciar()
    {
        audioManager.PlaySFX(audioManager.Botoes);
        GameObject.Find("Main Camera").GetComponent<PlayerStatus>().Resetar();
        SceneManager.LoadScene("salaJogavel1");
    }

    public void Menu()
    {
        audioManager.PlaySFX(audioManager.Botoes);
        SceneManager.LoadScene("TelaMenu");
    }

    public void TutorialFase()
    {
        audioManager.PlaySFX(audioManager.Botoes);
        GameObject.Find("Main Camera").GetComponent<PlayerStatus>().Resetar();
        SceneManager.LoadScene("CenaTutorial");
    }
}
