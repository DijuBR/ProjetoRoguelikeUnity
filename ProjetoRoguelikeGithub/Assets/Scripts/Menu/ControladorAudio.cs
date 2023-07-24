using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAudio : MonoBehaviour
{
    [Header("-----------AudioSouce----------")]

    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource Stompsource;

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
    public AudioClip HitBoss;
    public AudioClip Stomp;

    [Header("- Geral Sons")]
    public AudioClip Portal;
    public AudioClip Botoes;
    public AudioClip BotaoCarta;

    ControladorAudio audioManager;

    public void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void PlayStomp(AudioClip clip)
    {
        Stompsource.PlayOneShot(clip);
    }
}
