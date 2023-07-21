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

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JogoPausado)
            {
                Resumir();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void Resumir()
    {
        
        menuPauseUI.SetActive(false);
        Time.timeScale = 1f;
        JogoPausado = false;
        Debug.Log("Resumido!");
        audioManager.PlaySFX(audioManager.Botoes);
    }

    public void Pausar()
    {
        menuPauseUI.SetActive(true);
        Time.timeScale = 0f;
        JogoPausado = true;
        Debug.Log("Pausado!");
    }
    
    public void Menu()
    {
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
}
