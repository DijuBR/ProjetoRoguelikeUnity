using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoArma : MonoBehaviour
{
    public Camera mainCam;
    public Transform pontoRot;
    float rotx;
    

    // Start is called before the first frame update
    void Start()
    {
        pontoRot = GameObject.FindGameObjectWithTag("PontoRot").GetComponent<Transform>();
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        ArmaGirandoPlayer();
    }

    void ArmaGirandoPlayer()
    {
        Vector3 playerPosition = pontoRot.position;
        Vector2 rotx = new Vector3(-180, 0);
        Vector3 playerScreenPos = mainCam.WorldToScreenPoint(playerPosition);
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 rotation = mousePos - playerScreenPos;
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        if(rotZ <= 90)
        {
            transform.eulerAngles = new Vector2(-180, 0);
        }
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
        /*if (transform.rotation.z < 90 && transform.rotation.z > -90)
        {
            Debug.Log("LADO DIREITO");
            transform.rotation = Quaternion.Euler(0, 0, rotZ);

        }
        if (transform.rotation.z > 90 && transform.rotation.z < -90)
        {
            Debug.Log("LADO ESQUERDO");
            transform.rotation = Quaternion.Euler(-180, 0, rotZ);
        }*/
        

        

    }
}
