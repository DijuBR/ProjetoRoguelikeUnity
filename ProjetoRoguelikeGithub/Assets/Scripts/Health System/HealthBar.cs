using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public VidaPlayer player;

    public PlayerStatus status;

    public void Awake()
    {
        status = GameObject.FindWithTag("Player").GetComponent<PlayerStatus>();
    }

    public void MaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    
    public void SetHealth(float health)
    {
        slider.value = health;
    }

}
