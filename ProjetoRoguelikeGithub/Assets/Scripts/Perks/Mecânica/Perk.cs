using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perk : MonoBehaviour
{
    public PowerUpEffect powerUpEffect;
    //public PlayerStatus valor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Reconhece a colisão com o player para obter o powerUp
        Destroy(gameObject);
        //powerUpEffect.Apply(collision.gameObject);
    }
    private void Start()
    {
        //valor = GetComponent<PlayerStatus>();
    }
    public void AplicarPerk()
    {
        powerUpEffect.Apply();
    }
}
