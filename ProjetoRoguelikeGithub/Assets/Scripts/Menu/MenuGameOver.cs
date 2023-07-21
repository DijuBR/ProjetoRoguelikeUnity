using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    ControladorAudio audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    public void Start()
    {
        
        audioManager.PlaySFX(audioManager.Morte);
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
}
