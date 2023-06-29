using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControleBotao : Perk
{
    public GameObject pai;
    public PlayerStatus status;

    public void PerkApply()
    {
        AplicarPerk();
    }

    private void Update()
    {
        powerUpEffect = pai.GetComponentInChildren<Perk>().powerUpEffect;
    }
}
