using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossBarraDeVida : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private GameObject boss;
    [SerializeField] private RectTransform pos;

    // Start is called before the first frame update
    void Start()
    {
        boss = GameObject.FindWithTag("Boss");
        pos = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        pos.transform.rotation = Quaternion.Euler(0, 0, 0);
        slider.value = boss.GetComponent<BossScript>().vidaBoss / boss.GetComponent<BossScript>().vidaBossMax;
    }
}
