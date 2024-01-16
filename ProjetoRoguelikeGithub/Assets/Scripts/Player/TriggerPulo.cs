using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPulo : MonoBehaviour
{
    PlayerMovement script;
    void Start()
    {
        script = GetComponentInParent<PlayerMovement>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("ChaoTileMap") || col.CompareTag("Plataforma"))
        {
            script.pulos = 1;
        }
    }
}
