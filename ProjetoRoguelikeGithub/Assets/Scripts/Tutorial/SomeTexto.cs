using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeTexto : MonoBehaviour
{
    public GameObject texto;
    
    // Start is called before the first frame update
    void Start()
    {
        texto.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Some()
    {
        texto.SetActive(false);
    }
}
