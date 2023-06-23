using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private RectTransform pos1;
    private RectTransform pos2;
    private RectTransform pos3;
    [SerializeField] private GameObject[] cartas;
    // Start is called before the first frame update
    void Start()
    {
        pos1 = GameObject.Find("Slot 1").GetComponent<RectTransform>();
        pos2 = GameObject.Find("Slot 2").GetComponent<RectTransform>();
        pos3 = GameObject.Find("Slot 3").GetComponent<RectTransform>();
        GerarCartasFull();
    }

    void GerarCartasFull()
    {
        //Escolhendo as cartas dentro do array de cartas
        int r1 = Random.Range(0, cartas.Length);
        int r2 = Random.Range(0, cartas.Length);
        int r3 = Random.Range(0, cartas.Length);

        //Instancia a carta do primeiro slot
        Instantiate(cartas[r1], pos1);
        while(r2 == r1)
        {
            r2 = Random.Range(0, cartas.Length);
        }
        Instantiate(cartas[r2], pos2);
        while(r3 == r2 || r3 == r1)
        {
            r3 = Random.Range(0, cartas.Length);
        }
        Instantiate(cartas[r3], pos3);
    }
}
