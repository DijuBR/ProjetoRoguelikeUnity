using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject texto;
    public BoxCollider2D colliderP;
    private bool inimigosTela;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Inimigo") == false)
        {
            texto.SetActive(true);
                
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
