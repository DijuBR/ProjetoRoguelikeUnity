using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Perks/Speed")]

public class SpeedPerk : PowerUpEffect
{
    public int quant;


    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerMovement>().velPlayer += quant;

    }
}
