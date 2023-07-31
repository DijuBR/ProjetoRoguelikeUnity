using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BonecoAnda : MonoBehaviour
{
    [SerializeField] private Animator bonecoAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao == 0)
        {
            bonecoAnimator.Play("Fase1");
        }

        if (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao == 1)
        {
            bonecoAnimator.Play("Fase2");
        }

        if (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao == 2)
        {
            bonecoAnimator.Play("Fase3");
        }

        if (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao == 3)
        {
            bonecoAnimator.Play("Fase4");
        }

        if (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao == 4)
        {
            bonecoAnimator.Play("Fase5");
        }

        if (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao == 6)
        {
            bonecoAnimator.Play("Fase6");
        }


    }

    public void EventoFase()
    {
        SceneManager.LoadScene("CenaCartas");
    }

    public void BossFase()
    {
        SceneManager.LoadScene("CartasBoss");
    }
}
