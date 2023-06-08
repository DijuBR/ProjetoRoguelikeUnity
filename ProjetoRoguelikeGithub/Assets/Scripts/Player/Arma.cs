using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject inimigo;
    public GameObject tiroPlayer;
    public Transform tiroPlayerPos;
    public Transform arma;
    // Start is called before the first frame update
    void Start()
    {
        inimigo = GameObject.FindGameObjectWithTag("Inimigo");
        arma = GameObject.FindGameObjectWithTag("Arma").GetComponent<Transform>();

       
    }

    // Update is called once per frame
    void Update()
    {
        AtirarPlayer();
       
    }

    void AtirarPlayer()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("ATIRANDO");
            Instantiate(tiroPlayer, tiroPlayerPos.position, Quaternion.identity);
        }
    }
    void CompararInimigo()
    {

    }
}
