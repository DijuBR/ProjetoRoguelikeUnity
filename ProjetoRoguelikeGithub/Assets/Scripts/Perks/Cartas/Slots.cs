using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private RectTransform pos;
    [SerializeField] private GameObject[] cartas;
    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<RectTransform>();
        int r = Random.Range(0, cartas.Length);
        Instantiate(cartas[r], pos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
