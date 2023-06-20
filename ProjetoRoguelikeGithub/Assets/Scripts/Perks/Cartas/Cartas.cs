using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cartas : MonoBehaviour
{

    public GameObject[] cartas;
    public GameObject[] slots;
    // Start is called before the first frame update
    void Start()
    {
        int gerarCartas = Random.Range(0, cartas.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
