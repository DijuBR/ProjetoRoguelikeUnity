using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public HealthSystem healthSys;
    public void Awake()
    {
        healthSys = GameObject.FindWithTag("Player").GetComponent<HealthSystem>();
    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }
    public void MaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    
    

}
