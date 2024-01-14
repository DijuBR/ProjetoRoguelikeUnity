using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStats : MonoBehaviour
{
    public Stats stats;
    

    private void Start() {
        Debug.Log(stats.vida);
    }
}
