using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomNaCena : MonoBehaviour
{
    // Start is called before the first frame update

    ControladorAudio audioManager;
    
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
        audioManager.PlaySFX(audioManager.Botoes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
