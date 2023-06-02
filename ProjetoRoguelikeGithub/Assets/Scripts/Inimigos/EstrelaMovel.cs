using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstrelaMovel : MonoBehaviour
{
    private float pontoCentral;
    public GameObject pontoEsq;
    public GameObject pontoDir;
    private Vector2 novaPos;
    public float veloEstrela;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        novaPos = pontoDir.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GiraEstrela();
        MoveEstrela();
    }

    private void GiraEstrela()
    {
        pontoCentral = pontoCentral + Time.deltaTime * 1000;
        transform.rotation = Quaternion.Euler(0, 0, pontoCentral);
    }

    private void MoveEstrela()
    {
        if(transform.position == pontoDir.transform.position)
        {
            novaPos = pontoEsq.transform.position;
        }

        if (transform.position == pontoEsq.transform.position)
        {
            novaPos = pontoDir.transform.position;
        }

        transform.position = Vector2.MoveTowards(transform.position, novaPos, veloEstrela * Time.deltaTime);
    }
}
