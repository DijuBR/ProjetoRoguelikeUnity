using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVidaInimigo : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private RectTransform pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        pos.transform.rotation = Quaternion.Euler(0, 0, 0);
        slider.value = GetComponentInParent<VidaInimigo>().vidaInimigo / GetComponentInParent<VidaInimigo>().vidaIniMax;
    }
}
