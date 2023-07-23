using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossParedeCol : MonoBehaviour
{
    GameObject pai;
    bool virado = false;
    // Start is called before the first frame update
    void Start()
    {
        pai = GameObject.Find("Boss");
    }

    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("ChaoTileMap") && virado == false || col.CompareTag("DomoTileMap") && virado == false)
        {
            pai.transform.rotation = Quaternion.Euler(0, 180, 0);
            virado = true;
        }
        else if (col.CompareTag("ChaoTileMap") && virado == true || col.CompareTag("DomoTileMap") && virado == true)
        {
            pai.transform.rotation = Quaternion.Euler(0, 0, 0);
            virado = false;
        }
    }
}
