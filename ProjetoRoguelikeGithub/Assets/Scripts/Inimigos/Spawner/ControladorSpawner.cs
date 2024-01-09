using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSpawner : MonoBehaviour
{
    [Header("Posicao e Inimigos")]
    public Transform[] pos;
    public GameObject[] ini;
    private int quantmin;
    private int quantmax;

    private void Awake() {
        int quantmin = 0;

        while (quantmin <= quantmax)
        {
            quantmin++;
            Spawnar();
        }
    }
    void Spawnar(){
        quantmax = Random.Range(2,4);
        int iniR = Random.Range(0, ini.Length);
        int posR = Random.Range(0, pos.Length);
        Instantiate(ini[iniR], pos[posR]);





        //quantmax = Random.Range(2,4);
        //while (quantmin <= quantmax){
        //quantmin++;
        //int iniR = Random.Range(0, ini.Length);
        //int posR = Random.Range(0, pos.Length);
        //Instantiate(ini[iniR], pos[posR]);
        }
        //int iniR = Random.Range(0, ini.Length);
        //int posR = Random.Range(0, pos.Length);
        //Instantiate(ini[iniR], pos[posR]);
    }
