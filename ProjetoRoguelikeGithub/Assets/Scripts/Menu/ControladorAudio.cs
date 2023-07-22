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
    public AudioClip Portal;
    public AudioClip Botoes;
    public AudioClip BotaoCarta;

    [Header("- Músicas")]
    public AudioClip MenuMS;
    public AudioClip MSFase1;
    public AudioClip MSFase2;
    public AudioClip MSFase3;

    ControladorAudio audioManager;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlayMS(AudioClip clipMS)
    {
        musicSource.PlayOneShot(clipMS);
    }
}
