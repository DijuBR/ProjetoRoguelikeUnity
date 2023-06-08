using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject inimigo;
    public GameObject tiroPlayer;
    public Transform tiroPlayerPos;

    private Camera mainCam;
    public GameObject rbPlayer;
    private Vector3 mousePos;

    



    // Start is called before the first frame update
    void Start()
    {
        inimigo = GameObject.FindGameObjectWithTag("Inimigo");
        mainCam = GameObject.FindGameObjectWithTag("Player").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        AtirarPlayer();
        ArmaGirandoPlayer();
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
    void ArmaGirandoPlayer()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
