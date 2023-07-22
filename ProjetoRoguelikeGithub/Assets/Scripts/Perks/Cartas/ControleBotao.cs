using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ControleBotao : Perk
{
    public GameObject pai;
    public GameObject texto;
    public PlayerStatus status;
    public string textoBotao;
    ControladorAudio audioManager;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    public void PerkApply()
    {
        audioManager.PlaySFX(audioManager.BotaoCarta);
        AplicarPerk();
    }

    private void Update()
    {
        powerUpEffect = pai.GetComponentInChildren<Perk>().powerUpEffect;
        textoBotao = pai.GetComponentInChildren<Perk>().info1;
    }
}
