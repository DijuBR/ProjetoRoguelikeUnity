using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public List<ItemList> items = new List<ItemList>();


    //Vida
    public float vida;              //Vida
    public float numCora;           //N�mero de cora��es
    //Tiro
    public float   dano;              //Dano
    public float velTiro;           //Velocidade da bala
    public float disTiro;           //Dist�ncia m�xima da bala
    public float fireRate;          //Velocidade que atira
    //Movimenta��o
    public float velPlayer;         //Velocidade do jogador
    public float forcPulo;          //For�a do pulo
    //Score
    public int pontuacao;
    public int score;
    public int spawn;
    
    private void Start()
    {
        Getar();
        FireDamageItem item = new FireDamageItem();
        items.Add(new ItemList(item, item.GiveName(),2));
        StartCoroutine(CallItemUpdate());    
    }

    private void Update()
    {
        Setar();


        
    }
    IEnumerator CallItemUpdate(){
        foreach(ItemList i in items){
            i.item.Update(this,i.stack);
        }
        yield return new WaitForSeconds(1);
        StartCoroutine(CallItemUpdate());
    }

    public void CallItemOnHit(VidaInimigo ini){
        foreach(ItemList i in items){
            i.item.OnHit(this,ini, i.stack);
        }
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

        spawn = 3;
    }
    public void Setar(){


    //VIDA
        PlayerPrefs.SetFloat("VIDA", vida);
        PlayerPrefs.SetFloat("NUMCORA", numCora);
        //ARMA
        PlayerPrefs.SetFloat("DANO", dano);
        PlayerPrefs.SetFloat("VELTIRO", velTiro);
        PlayerPrefs.SetFloat("DISTIRO", disTiro);
        PlayerPrefs.SetFloat("FIRERATE", fireRate);
        //Movimenta��o
        PlayerPrefs.SetFloat("VELPLAYER", velPlayer);
        PlayerPrefs.SetFloat("FORCPULO", forcPulo);
        //Score
        PlayerPrefs.SetInt("spawn", spawn);
    }
    public void Getar(){
        velPlayer = PlayerPrefs.GetFloat("VELPLAYER");
        dano = PlayerPrefs.GetFloat("DANO");
        vida = PlayerPrefs.GetFloat("VIDA");
        numCora = PlayerPrefs.GetFloat("NUMCORA");
        velTiro = PlayerPrefs.GetFloat("VELTIRO");
        disTiro = PlayerPrefs.GetFloat("DISTIRO");
        fireRate = PlayerPrefs.GetFloat("FIRERATE");
        forcPulo = PlayerPrefs.GetFloat("FORCPULO");
        spawn = PlayerPrefs.GetInt("spawn");
    }
}

