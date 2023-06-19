using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoArma : MonoBehaviour
{
    public Camera mainCam;
    public Transform pontoRot;
    float rotx;
    float numN;
    float num;
    

    // Start is called before the first frame update
    public void Start()
    {
        pontoRot = GameObject.FindGameObjectWithTag("PontoRot").GetComponent<Transform>();
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        numN = -1;
        num = 1;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        ArmaGirandoPlayer();
    }

    void ArmaGirandoPlayer()
    {
        
        Vector3 playerPosition = pontoRot.position;
        Vector3 eixoYN = transform.localScale;
        Vector3 eixoY = transform.localScale;
        eixoY.y = num;
        eixoYN.y = numN;
        Vector2 rotx = new Vector3(-180, 0);
        Vector3 playerScreenPos = mainCam.WorldToScreenPoint(playerPosition);
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 rotation = mousePos - playerScreenPos;
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);


        if(rotZ == -90 || rotZ >= -89 && rotZ <= 88|| rotZ == 89)
        {
            transform.localScale = eixoY;
        }



        if(rotZ == 90 || rotZ >= 91 && rotZ <= 179 || rotZ == -91 || rotZ == -180 || rotZ >= -179 && rotZ <= -92)
        {
            transform.localScale = eixoYN;
        }

    }
}
