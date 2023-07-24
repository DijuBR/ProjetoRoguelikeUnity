using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PainelMenu : MonoBehaviour
{
    public bool JogoPausado = false;
    public GameObject menuPauseUI;
    ControladorAudio audioManager;
    public GameObject player;
    public GameObject arma;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
        player = GameObject.FindWithTag("Player");
        arma = GameObject.FindWithTag("Arma");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JogoPausado == true)
            {
                Resumir();
            }
            if (JogoPausado == false)
            {
                Pausar();
            }
        }
    }

    public void Resumir()
    {
        menuPauseUI.SetActive(false);
        Time.timeScale = 1f;
        ScriptsON();
        JogoPausado = false;
        Debug.Log("Resumido!");
        audioManager.PlaySFX(audioManager.Botoes);
    }

    public void Pausar()
    {
        menuPauseUI.SetActive(true);
        Time.timeScale = 0f;
        ScriptsOFF();
        JogoPausado = true;
        Debug.Log("Pausado!");
    }
    
    public void Menu()
    {
        Time.timeScale = 1f;
        Debug.Log("Menu!!!");
        audioManager.PlaySFX(audioManager.Botoes);
        SceneManager.LoadScene("TelaMenu");
    }
    
    public void Sair()
    {
        Debug.Log("Saiu!!!");
        audioManager.PlaySFX(audioManager.Botoes);
        Application.Quit();
    }

    void ScriptsON()
    {
        player.GetComponent<PlayerMovement>().enabled = true;
        arma.GetComponent<Arma>().enabled = true;
    }
    void ScriptsOFF()
    {
        player.GetComponent<PlayerMovement>().enabled = false;
        arma.GetComponent<Arma>().enabled = false;
    }
}
