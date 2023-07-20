using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAudio : MonoBehaviour
{
    [Header("AudioSouce")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("AudioClips")]
    public AudioClip background;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }
}
