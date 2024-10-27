using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayerNOVO : MonoBehaviour
{
   ControladorAudio audioManager;
   [Header("---------VARIAVEIS IMORTALIDADE----------")]
   private bool estaImortal;
   public int tempoImortal;
   
   [Header("---------CORACOES GERAL---------")]
   public int numCoracoes;
   public float vida;
   public Image[] imgCoracoes;
   public Sprite coraVazio, coraCheio, coraEscudo, coraMetade;



   private void Start() {
      audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>(); 
   }
   private void Update() {
      ReferenciarCoracoes();
      
   }

    private void OnCollisionStay2D(Collision2D col2)
    {
       if (col2.gameObject.CompareTag("Inimigo"))
       {
        Dano();
        
       }
    }
   void ReferenciarCoracoes(){

      /*EM ORDEM, ELE VAI:
      -Fazer um for que contém cada coração na tela (10 coracoes máximos até o momento)
      e referenciar que pra quantidade de vida atual seja = a um coração
      -Ideia Futura: Coração de Escudo, coração que você toma um dano e ele quebra
      */
      for(int i = 0;i < imgCoracoes.Length; i++)
      {
         if(i <vida){
            imgCoracoes[i].sprite = coraCheio;
            if(vida == i + 0.5){
               imgCoracoes[i].sprite = coraMetade;
            }
         }
         else{
            imgCoracoes[i].sprite = coraVazio;
         }
         
         if(i <numCoracoes)
         {
            imgCoracoes[i].enabled = true;
         }
         else
         {
            imgCoracoes[i].enabled = false;
         }
      }

   }
   private IEnumerator TempImortal()
    {
        estaImortal = true;
        Debug.Log("Player Imortal: " + estaImortal);
        yield return new WaitForSeconds(tempoImortal);
        estaImortal = false;
        Debug.Log("Player Imortal: " + estaImortal);
    }
   public void Dano(int danoRecebido)
    {
        if(estaImortal == false)
        {
            vida -= danoRecebido;
            GetComponent<FlashDano>().FlashRun();
            audioManager.PlaySFX(audioManager.Dano);
            StartCoroutine("TempImortal");
        }
        
    }
}


  
   


