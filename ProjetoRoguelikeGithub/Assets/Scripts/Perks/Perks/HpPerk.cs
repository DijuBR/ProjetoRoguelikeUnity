using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Perks/Vida")]
public class HpPerk : PowerUpEffect
{
    public int quant;
    public GameObject player;
    public string info;


    public override void Apply()
    {
        player = GameObject.Find("PlayerTeste");
        player.GetComponent<PlayerStatus>();
        player.GetComponent<PlayerStatus>().vida += quant;

    }
}
