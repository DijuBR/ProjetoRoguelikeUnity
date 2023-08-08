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
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && concluido == true)
        {
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
