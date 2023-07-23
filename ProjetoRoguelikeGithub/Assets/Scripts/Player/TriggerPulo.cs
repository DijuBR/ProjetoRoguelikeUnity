using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPulo : MonoBehaviour
{
    PlayerMovement script;
    // Start is called before the first frame update
    void Start()
    {
        script = GetComponentInParent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("ChaoTileMap") || col.CompareTag("Plataforma"))
        {
            script.pulos = 1;
        }
    }
}
