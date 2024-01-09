using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleNotify : MonoBehaviour
{
    public GameObject [] ini;
    public Transform pos;

    public void Awake() {
        pos = this.gameObject.transform;
        int iniR = Random.Range(0, ini.Length);
    }
    public void Criar(int iniR){
        GameObject iniC = Instantiate(ini[iniR], pos);
        iniC.transform.parent = null;
        
    }
    public void Deletar(){
        Destroy(this.gameObject);
    }
}
