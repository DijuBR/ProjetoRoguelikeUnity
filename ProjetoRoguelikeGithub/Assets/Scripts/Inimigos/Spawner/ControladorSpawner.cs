using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSpawner : MonoBehaviour
{
    [Header("Posicao e Inimigos")]
    
    public BoxCollider2D[] col;
    public GameObject obj;
    private int quantmin;
    private int quantmax;

    private void Awake() {
        int quantmin = 0;
        while (quantmin <= quantmax)
        {
            quantmin++;
            NascerInimigo();
        }
    }
    public void NascerInimigo(){
        quantmax = Random.Range(2,4);
        int colR = Random.Range(0, col.Length);
        Vector2 colliderPos = new Vector2(col[colR].transform.position.x, col[colR].offset.y);
        float randomPosX = Random.Range(colliderPos.x - col[colR].size.x / 2, colliderPos.x + col[colR].size.x / 2);
        float randomPosY = Random.Range(colliderPos.y - col[colR].size.y / 2, colliderPos.y + col[colR].size.y / 2);        
        GameObject instantiatedObject = Instantiate(obj, new Vector3(randomPosX, randomPosY), Quaternion.identity);

    }
}
