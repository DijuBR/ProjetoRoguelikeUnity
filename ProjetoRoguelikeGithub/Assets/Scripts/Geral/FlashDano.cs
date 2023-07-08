using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashDano : MonoBehaviour
{

    [SerializeField] private Material flashMat;
    [SerializeField] private float duracao = 0.25f;


    private SpriteRenderer sprite;
    private Material oriMaterial;
    private Coroutine coroutine;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        oriMaterial = sprite.material;
    }
    private IEnumerator FlashLoop()
    {
        //Troca para o material de flash
        sprite.material = flashMat;

        //Pausa o script por x segundos;
        yield return new WaitForSeconds(duracao);

        //Depois da pausa, retorna para o material original
        sprite.material = oriMaterial;

        //Sinaliza null para finalização do loop
        coroutine = null;
    }

    public void FlashRun()
    {
        //Se diferente de null, aplique flash ao objeto.
        if(coroutine != null)
        {
            //Pare a rotina de Flash primeiro, porque pode bugar.
            StopCoroutine(coroutine);
        }
        StartCoroutine(FlashLoop());
    }
}
