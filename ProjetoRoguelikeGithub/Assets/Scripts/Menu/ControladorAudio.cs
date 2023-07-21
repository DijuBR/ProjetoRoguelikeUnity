using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAudio : MonoBehaviour
{
    [Header("-----------AudioSouce----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("- Player Sons")]
    
    [Header("----------AudioClips----------")]
    public AudioClip Andando;
    public AudioClip Pulando;
    public AudioClip Dano;
    public AudioClip Morte;

    [Header("- Arma Sons")]
    public AudioClip Atirando;
    public AudioClip TiroExplodindo;

    [Header("- Inimigo Sons")]
    public AudioClip Atirainimigo;
    public AudioClip Hit;

    [Header("- Boss Sons")]
    public AudioClip AtiraBoss;
    public AudioClip AndaBoss;
    public AudioClip Stomp;

    [Header("- Geral Sons")]
    public AudioClip BGMusica;
    public AudioClip Portal;
    public AudioClip Botoes;
    public AudioClip CenaBotoes;

    ControladorAudio audioManager;

    public void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    private void Start()
    {
        audioManager.PlaySFX(audioManager.BGMusica);
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
