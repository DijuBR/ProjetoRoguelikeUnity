using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossBarraDeVida : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private GameObject boss;

    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.FindWithTag("Boss");
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = boss.GetComponent<BossScript>().vidaBoss / boss.GetComponent<BossScript>().vidaBossMax;
    }
}
