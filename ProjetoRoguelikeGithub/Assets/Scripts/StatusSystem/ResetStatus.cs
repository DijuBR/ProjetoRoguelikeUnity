using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetStatus : MonoBehaviour
{
    public StartStats ss;
    public Stats stats;

    private void Start() {
        
    }
    private void Awake() {
    //Vida
    stats.vida =    ss.vida;
    stats.numCora = ss.numCora;
    //Ataque
    stats.dmg = ss.dmg;
    stats.shotSpeed = ss.shotSpeed;
    stats.fireRate = ss.fireRate;
    //Movimentacao
    stats.moveSpeed = ss.moveSpeed;
    stats.jumpForce = ss.jumpForce;
    }    
}
