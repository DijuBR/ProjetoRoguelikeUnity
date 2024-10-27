using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour
{
    public GameObject[] quantidadeInimigos;
    public GameObject texto;
    public int quantidadeIni;





    private void Update() {
        quantidadeInimigos = GameObject.FindGameObjectsWithTag("Inimigo");
        if(quantidadeIni <= 0){
            texto.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && quantidadeInimigos.Length == 0)
        {
            SceneManager.LoadScene("CenaMostraFase");
        }
         
    }

}
