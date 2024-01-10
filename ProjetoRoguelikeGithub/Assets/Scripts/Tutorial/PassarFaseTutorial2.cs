using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarFaseTutorial2 : MonoBehaviour
{
    private bool concluido = false;
    public PortalScriptTutorial2 portalscripttutorial;

    // Start is called before the first frame update
    void Start()
    {
        portalscripttutorial = GetComponent<PortalScriptTutorial2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (portalscripttutorial.spawner.GetComponent<SpawnerTutorialFase>().inimigosnascidos == 0)
        {
            concluido = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && concluido == true)
        {
            SceneManager.LoadScene("TutorialConcluido");
        }
    }
}
