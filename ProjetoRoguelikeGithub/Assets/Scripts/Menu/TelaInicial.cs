using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{
    ControladorAudio audioManager;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }


    // Start is called before the first frame update
    public void Play()
    {
        audioManager.PlaySFX(audioManager.Botoes);
        GameObject.Find("Main Camera").GetComponent<PlayerStatus>().Resetar();
        SceneManager.LoadScene("SalaJogavel1");
        
    }

    public void Tutorial()
    {
        audioManager.PlaySFX(audioManager.Botoes);
        GameObject.Find("Main Camera").GetComponent<PlayerStatus>().Resetar();
        SceneManager.LoadScene("CenaTutorial");

    }

    // Update is called once per frame
    public void ExitGame()
    {
        print("Saiu");
        audioManager.PlaySFX(audioManager.Botoes);
        GameObject.Find("Main Camera").GetComponent<PlayerStatus>().Resetar();
        Application.Quit();
    }
}
