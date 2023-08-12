using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarFase : MonoBehaviour
{
    private bool concluido = false;
    public PortalScript portalscript;

    void Start()
    {
        portalscript = GetComponent<PortalScript>();
    }

    void Update()
    {
        if(portalscript.spawner.GetComponent<EnemySpawn>().inimigosnascidos == 0)
        {
            concluido = true;
        }

        switch (GameObject.FindWithTag("Player").GetComponent<PlayerStatus>().pontuacao)
        {
            case (0):
                GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().spawn = Random.Range(3, 4);
                break;
            case (1):
                GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().spawn = Random.Range(3, 5);
                break;
            case (2):
                GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().spawn = Random.Range(4, 6);
                break;
            case (3):
                GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().spawn = Random.Range(5, 7);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && concluido == true)
        {
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().spawn++;
            SceneManager.LoadScene("CenaMostraFase");
        }

        if(col.CompareTag("Player") && concluido == true && GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao == 5)
        {
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao++;
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().score++;
            SceneManager.LoadScene("CenaMostraFase");
        }
    }

}
