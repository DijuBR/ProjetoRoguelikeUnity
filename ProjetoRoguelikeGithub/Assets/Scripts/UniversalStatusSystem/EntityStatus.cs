using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EntityStatus : MonoBehaviour
{
    public UniStatusSys stat;

    public HealthBar healthBar;

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

    private void Awake() {
        hp = stat.hp;
        dmgAmount = stat.dmgAmount;
        fireRate = stat.fireRate;
        shotSpeed = stat.shotSpeed;
        shotRange = stat.shotRange;
        moveSpeed = stat.moveSpeed;
        jumpForce = stat.jumpForce;
    }

    public void Start()
    {
        hpMax = hp;
        healthBar.MaxHealth(hpMax);
    }


}
