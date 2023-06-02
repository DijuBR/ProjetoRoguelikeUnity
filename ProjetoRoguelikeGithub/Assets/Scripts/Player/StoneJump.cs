using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneJump : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            GameObject.Find("Inimigo").GetComponent<Inimigo>().vidainimigo = 0;
        }

        
    }
    private void Start()
    {
        
    }
}
