using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    //Vida
    public float vida;              //Vida
    public float numCora;           //Número de corações
    //Tiro
    public int   dano;              //Dano
    public float velTiro;           //Velocidade da bala
    public float disTiro;           //Distância máxima da bala
    public float fireRate;          //Velocidade que atira
    //Movimentação
    public float velPlayer;         //Velocidade do jogador
    public float forcPulo;          //Força do pulo
    
    private void Start()
    {
        
        velPlayer = PlayerPrefs.GetFloat("VELPLAYER");
        dano = PlayerPrefs.GetInt("DANO");
        vida = PlayerPrefs.GetFloat("VIDA");
        numCora = PlayerPrefs.GetFloat("NUMCORA");
        velTiro = PlayerPrefs.GetFloat("VELTIRO");
        disTiro = PlayerPrefs.GetFloat("DISTIRO");
        fireRate = PlayerPrefs.GetFloat("FIRERATE");
        forcPulo = PlayerPrefs.GetFloat("FORCPULO");
    }

    private void Update()
    {
        //VIDA
        PlayerPrefs.SetFloat("VIDA", vida);
        PlayerPrefs.SetFloat("NUMCORA", numCora);
        //ARMA
        PlayerPrefs.SetInt("DANO", dano);
        PlayerPrefs.SetFloat("VELTIRO", velTiro);
        PlayerPrefs.SetFloat("DISTIRO", disTiro);
        PlayerPrefs.SetFloat("FIRERATE", fireRate);
        //Movimentação
        PlayerPrefs.SetFloat("VELPLAYER", velPlayer);
        PlayerPrefs.SetFloat("FORCPULO", forcPulo);
        Resetar();
    }

    private void Resetar()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().velPlayer = 7;
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().forcPulo = 7;

            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().dano = 5;
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().velTiro = 3;
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().disTiro = 0.7f;
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().fireRate = 0.75f;

            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().vida = 3;
            GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().numCora = 3;
        }
    }

}
