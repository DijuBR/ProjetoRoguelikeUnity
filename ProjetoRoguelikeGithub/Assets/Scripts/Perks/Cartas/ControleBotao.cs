using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleBotao : MonoBehaviour
{
    public PowerUpEffect powerupeffect;
    public void AplicarPerk()
    {
        Destroy(gameObject);
        //powerupeffect.Apply(gameObject);
    }

    



}
