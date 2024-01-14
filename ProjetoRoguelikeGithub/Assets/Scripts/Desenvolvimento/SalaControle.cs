using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalaControle : MonoBehaviour
{
    public int abrirDirecao;
    //1 --> precisa de uma porta pra direita
    //2 --> precisa de uma porta pra esquerda


    private SalaTemplates templates;
    private int rand;
    private bool spawnado = false;

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Salas").GetComponent<SalaTemplates>();
        Invoke("Spawn", 0.1f);
    }


    void Spawn()
    {
        if(spawnado == false)
        {
            if (abrirDirecao == 1)
            {
                //precisa de uma SalaDir
                rand = Random.Range(0, templates.SalasDir.Length);
                Instantiate(templates.SalasDir[rand], transform.position, templates.SalasDir[rand].transform.rotation);
            }
            else if (abrirDirecao == 2)
            {
                //precisa de uma SalaEsq
                rand = Random.Range(0, templates.SalasEsq.Length);
                Instantiate(templates.SalasEsq[rand], transform.position, templates.SalasEsq[rand].transform.rotation);
            }
            spawnado = true;
        }
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if(outro.CompareTag("SpawnPoint") && outro.GetComponent<SalaControle>().spawnado == true)
        {
            Destroy(gameObject);
        }
    }
}
