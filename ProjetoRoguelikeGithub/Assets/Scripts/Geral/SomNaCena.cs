using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomNaCena : MonoBehaviour
{

    ControladorAudio audioManager;
    
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
        audioManager.PlaySFX(audioManager.Botoes);
    }
}
