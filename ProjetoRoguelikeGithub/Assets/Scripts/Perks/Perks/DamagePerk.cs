using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Perks/Damage")]

public class DamagePerk : PowerUpEffect
{

    public int quant;
    public GameObject player;
    public PlayerStatus status;


    public override void Apply()
    {
        player = GameObject.Find("PlayerTeste");
        player.GetComponent<PlayerStatus>();
        player.GetComponent<PlayerStatus>().dano *= 1.2f;
        
    }
}
