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
    public int score;
    public int spawn;
    
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
        score = PlayerPrefs.GetInt("SCORE");
        spawn = PlayerPrefs.GetInt("spawn");
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
        PlayerPrefs.SetInt("SCORE", score);
        PlayerPrefs.SetInt("spawn", spawn);
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
        score = 0;
        spawn = 3;
    }

}
