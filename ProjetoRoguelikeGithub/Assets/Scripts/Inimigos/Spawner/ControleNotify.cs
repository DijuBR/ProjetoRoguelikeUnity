using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleNotify : MonoBehaviour
{
    public GameObject [] ini;
    public Transform pos;

    public void Awake() {
        pos = this.gameObject.transform;
    }
    public void Criar(){
        int iniR = Random.Range(0, ini.Length);
        GameObject iniC = Instantiate(ini[iniR], pos);
        iniC.transform.parent = null;
        
    }
    public void Deletar(){
        Destroy(this.gameObject);
    }
}
