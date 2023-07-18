using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CartasTexto : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public PowerUpEffect perk;
    public GameObject slot;
    public GameObject carta;
    public string msg;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        txt = GetComponent<TextMeshProUGUI>();
        txt.text = GetComponentInParent<ControleBotao>().textoBotao;
    }
}
