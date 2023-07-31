using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarFaseTutorial : MonoBehaviour
{
    private bool concluido = false;
    public PortalScripTutorial portalscripttutorial;

    // Start is called before the first frame update
    void Start()
    {
        portalscripttutorial = GetComponent<PortalScripTutorial>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(GameObject.Find("Spawner").GetComponent<EnemySpawn>().inimigosnascidos == 0 || GameObject.Find("SpawnerNoite").GetComponent<EnemySpawn>().inimigosnascidos == 0)
        //{
        //    concluido = true;   
        //}
        if (portalscripttutorial.spawner.GetComponent<SpawnerTutorial>().inimigosnascidos == 0)
        {
            concluido = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && concluido == true)
        {
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao++;
            SceneManager.LoadScene("CenaCartasTutorial");
        }
    }
}
