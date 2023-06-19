using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Perks/Vida")]
public class HpPerk : PowerUpEffect
{
    public int quant;


    public override void Apply(GameObject target)
    {
        target.GetComponent<VidaPlayer>().vida += quant;
        
    }
}
