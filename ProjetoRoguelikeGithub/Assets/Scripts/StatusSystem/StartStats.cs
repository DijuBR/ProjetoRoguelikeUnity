using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "StartStats", menuName = "Stats/StartStats")]
public class StartStats : ScriptableObject
{
    //Vida
    [Header("Vida")]
    public float vida;
    public float numCora;
    //Ataque
    [Header("Ataque")]
    public float dmg;
    public float shotSpeed;
    public float fireRate;
    [Header("Movimentacao")]
    //Movimentacao
    public float moveSpeed;
    public float jumpForce;
}
