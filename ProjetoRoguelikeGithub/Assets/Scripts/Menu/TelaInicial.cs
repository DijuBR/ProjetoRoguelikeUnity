using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaInicial : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        GameObject.Find("Main Camera").GetComponent<PlayerStatus>().Resetar();
        SceneManager.LoadScene("SalaJogavel1");
        
    }

    // Update is called once per frame
    public void ExitGame()
    {
        print("Saiu");
        GameObject.Find("Main Camera").GetComponent<PlayerStatus>().Resetar();
        Application.Quit();
    }
}
