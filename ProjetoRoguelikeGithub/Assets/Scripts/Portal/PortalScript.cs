using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject texto;

    // Start is called before the first frame update
    void Start()
    {
        texto.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Spawner").GetComponent<EnemySpawn>().inimigosnascidos == 0)
        {
            texto.SetActive(true);
            
        }
    }
}
