using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Perks/VelTiroPerk")]
public class VelTiroPerk : PowerUpEffect
{
    public float quant;
    public GameObject player;
    public PlayerStatus status;


    public override void Apply()
    {
        player = GameObject.Find("PlayerTeste");
        player.GetComponent<PlayerStatus>();
        player.GetComponent<PlayerStatus>().velTiro += quant;

    }
}
