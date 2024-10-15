using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayerNOVO : MonoBehaviour
{
   ControladorAudio audioManager;
   public float vida;
   public int numCoracoes;
   [Header("---------TIPOS E QUANTIDADE DE CORACOES")]

   public Image[] imgCoracoes;
   public Sprite coraVazio, coraCheio, coraEscudo, coraMetade;



   private void Start() {
      audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<ControladorAudio>(); 
   }
   private void Update() {
      ReferenciarCoracoes();
      
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


}


  
   


