using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Perks/Damage")]

public class DamagePerk : PowerUpEffect
{

    public int quant;
    
    

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerStatus>().dano += quant;
    }
}
