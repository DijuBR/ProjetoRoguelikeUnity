using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject tiroPlayer;
    public Transform tiroPlayerPos;
    public Transform arma;
    ControladorAudio audioManager;

    public float delayTiro;
    private float tiroCD = 0.0f;
    
    void Start()
    {
        arma = GameObject.FindGameObjectWithTag("Arma").GetComponent<Transform>();
        delayTiro = GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().fireRate;
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>();
    }

    void Update()
    {
        delayTiro = PlayerPrefs.GetFloat("FIRERATE");
        AtirarPlayer();
    }

    void AtirarPlayer()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > tiroCD)
        {
            tiroCD = Time.time + delayTiro;
            audioManager.PlaySFX(audioManager.Atirando);
            Instantiate(tiroPlayer, tiroPlayerPos.position, Quaternion.identity);
        }
    }
}
