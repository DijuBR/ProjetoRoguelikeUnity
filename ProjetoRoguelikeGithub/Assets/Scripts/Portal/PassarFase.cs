using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarFase : MonoBehaviour
{
    private bool concluido = false;
    public PortalScript portalscript;

    ControladorAudio audioManager;

    private float delay = 3f;
    private float tempoPassado;

    // Start is called before the first frame update
    void Start()
    {
        portalscript = GetComponent<PortalScript>();

        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(GameObject.Find("Spawner").GetComponent<EnemySpawn>().inimigosnascidos == 0 || GameObject.Find("SpawnerNoite").GetComponent<EnemySpawn>().inimigosnascidos == 0)
        //{
        //    concluido = true;   
        //}
        if(portalscript.spawner.GetComponent<EnemySpawn>().inimigosnascidos == 0)
        {
            concluido = true;
        }

        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player") && concluido == true)
        {
            audioManager.PlaySFX(audioManager.Portal);

            tempoPassado += Time.deltaTime;

           SceneManager.LoadScene("CenaCartas");
        }
    }

}
