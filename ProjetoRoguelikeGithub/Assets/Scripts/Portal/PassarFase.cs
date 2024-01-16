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
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().spawn++;
            SceneManager.LoadScene("CenaMostraFase");
        }

        if(col.CompareTag("Player") && concluido == true) //tinha uma condi��o que usava o score, possiveis erros poder�o estar relacionados aqui
        {
            SceneManager.LoadScene("CenaMostraFase");
        }
    }

}
