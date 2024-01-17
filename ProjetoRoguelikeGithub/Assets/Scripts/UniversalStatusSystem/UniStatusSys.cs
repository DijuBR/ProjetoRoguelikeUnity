using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Universal Status System", menuName = "Universal System")]
public class UniStatusSys : ScriptableObject {
    
    //Refs HealthSystem
    [Header("Health")]
    public float hp, hpMax, hpMin ;
    [Header("Damage")]
    //Refs DamageSystem
    public float dmgAmount, fireRate, shotSpeed, shotRange;
    //Refs SpeedSystem
    [Header("Movement")]
    public float moveSpeed, jumpForce;
    //Refs Outros
    [Header("Outros")]
    public float luck, armor;
}
