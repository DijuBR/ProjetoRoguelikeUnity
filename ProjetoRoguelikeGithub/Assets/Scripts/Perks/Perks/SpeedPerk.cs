using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Perks/Speed")]

public class SpeedPerk : PowerUpEffect
{
    public int quant;
    private PlayerStatus status;
    private GameObject player;


    public override void Apply()
    {
        player = GameObject.Find("PlayerTeste");
        player.GetComponent<PlayerStatus>();
        player.GetComponent<PlayerStatus>().velPlayer += quant;

    }
}
