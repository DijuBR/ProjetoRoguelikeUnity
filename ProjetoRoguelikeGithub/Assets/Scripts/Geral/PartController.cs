using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartController : MonoBehaviour
{
    [SerializeField] ParticleSystem moveParticle;

    [Range(0, 10)]
    [SerializeField] int occurAfterVelocity;

    [Range(0, 0.2f)]
    [SerializeField] float dustFormationPeriod;

    [SerializeField] Rigidbody2D playerRb;

    float contador;

    private void Update()
    {
        contador += Time.deltaTime;

        if (Mathf.Abs(playerRb.velocity.x) > occurAfterVelocity)
        {
            if (contador > dustFormationPeriod)
            {
                moveParticle.Play();
                contador = 0;
            }
        }
    }


}
