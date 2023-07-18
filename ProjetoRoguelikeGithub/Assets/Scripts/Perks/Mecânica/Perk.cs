using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perk : MonoBehaviour
{
    public PowerUpEffect powerUpEffect;
    public string info1;

    private void Start()
    {
        
    }

    public void AplicarPerk()
    {
        powerUpEffect.Apply();
    }
}
