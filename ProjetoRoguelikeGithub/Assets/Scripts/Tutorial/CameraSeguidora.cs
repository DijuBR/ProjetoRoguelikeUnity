using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraSeguidora : MonoBehaviour
{
    public float SeguirVel = 2f;
    public Transform alvo;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(alvo.position.x, transform.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, SeguirVel * Time.deltaTime);
    }
}
