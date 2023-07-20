using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PainelMenu : MonoBehaviour
{
    public bool JogoPausado = false;
    public GameObject menuPauseUI;

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
        SceneManager.LoadScene("TelaMenu");
    }
    
    public void Sair()
    {
        Debug.Log("Saiu!!!");
        Application.Quit();
    }
}
