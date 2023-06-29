using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    //Vida
    public float vida;              //Vida
    public float numCora;           //Número de corações
    //Tiro
    public float   dano;              //Dano
    public float velTiro;           //Velocidade da bala
    public float disTiro;           //Distância máxima da bala
    public float fireRate;          //Velocidade que atira
    //Movimentação
    public float velPlayer;         //Velocidade do jogador
    public float forcPulo;          //Força do pulo
    //Score
    public int pontuacao;
    
    private void Start()
    {
        
        velPlayer = PlayerPrefs.GetFloat("VELPLAYER");
        dano = PlayerPrefs.GetFloat("DANO");
        vida = PlayerPrefs.GetFloat("VIDA");
        numCora = PlayerPrefs.GetFloat("NUMCORA");
        velTiro = PlayerPrefs.GetFloat("VELTIRO");
        disTiro = PlayerPrefs.GetFloat("DISTIRO");
        fireRate = PlayerPrefs.GetFloat("FIRERATE");
        forcPulo = PlayerPrefs.GetFloat("FORCPULO");
        pontuacao = PlayerPrefs.GetInt("PONTUACAO");
    }

    private void Update()
    {
        //VIDA
        PlayerPrefs.SetFloat("VIDA", vida);
        PlayerPrefs.SetFloat("NUMCORA", numCora);
        //ARMA
        PlayerPrefs.SetFloat("DANO", dano);
        PlayerPrefs.SetFloat("VELTIRO", velTiro);
        PlayerPrefs.SetFloat("DISTIRO", disTiro);
        PlayerPrefs.SetFloat("FIRERATE", fireRate);
        //Movimentação
        PlayerPrefs.SetFloat("VELPLAYER", velPlayer);
        PlayerPrefs.SetFloat("FORCPULO", forcPulo);
        //Score
        PlayerPrefs.SetInt("PONTUACAO", pontuacao);
    }

    public void Resetar()
    {
        velPlayer = 5;
        forcPulo = 7;

        dano = 5;
        velTiro = 3;
        disTiro = 1f;
        fireRate = 1.25f;

        vida = 3;
        numCora = 3;

        pontuacao= 0;
        //GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().velPlayer = 7;
        //GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().forcPulo = 7;

        //GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().dano = 5;
        //GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().velTiro = 3;
        //GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().disTiro = 0.7f;
        //GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().fireRate = 1.7f;

        //GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().vida = 3;
        //GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().numCora = 3;
    }

}
