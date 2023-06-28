using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassarFase : MonoBehaviour
{
    public int inimigomorto;
    public GameObject Portal;
    
    


    // Start is called before the first frame update
    void Start()
    {
        Portal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if(inimigomorto >= 1)
        //{
        //    Portal.SetActive(true);
        //}

        if (GameObject.Find("Spawner").GetComponent<EnemySpawn>().inimigosnascidos == 0)
        {
            Portal.SetActive(true);
        }


    }

    
}
