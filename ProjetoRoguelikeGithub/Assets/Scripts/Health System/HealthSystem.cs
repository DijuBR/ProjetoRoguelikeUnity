using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public EntityStatus status;
    public float hp, currentHP;
    public HealthBar bar;

    private void Awake() {
        bar = GameObject.Find("HealthBar").GetComponent<HealthBar>();
        //hp = status.hp;
        //currentHP = hp;
        //status = this.gameObject.GetComponent<EntityStatus>();
    }
    private void Start() {
        hp = status.hp;
        currentHP = hp;
        status = this.gameObject.GetComponent<EntityStatus>();
        bar.MaxHealth(hp);
    }
    

    /*public void Morrer(){
        if(status.hp <= 0){
            Destroy(this.gameObject);
        }
    }*/
}
