using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Perks/FireRatePerk")]
public class FireRatePerk : PowerUpEffect
{
    public float quant;
    public GameObject player;
    public PlayerStatus status;
    public string info;


    public override void Apply()
    {
        player = GameObject.Find("PlayerTeste");
        player.GetComponent<PlayerStatus>();
        player.GetComponent<PlayerStatus>().fireRate -= quant;

    }
}
