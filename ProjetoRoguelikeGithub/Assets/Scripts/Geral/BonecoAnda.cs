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
        switch (GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().pontuacao)
        {
            case 0:
                bonecoAnimator.Play("Fase1");
                break;
            case 1:
                bonecoAnimator.Play("Fase2");
                break;
            case 2:
                bonecoAnimator.Play("Fase3");
                break;
            case 3:
                bonecoAnimator.Play("Fase4");
                break;
            case 4:
                bonecoAnimator.Play("Fase5");
                break;
            case 6:
                bonecoAnimator.Play("Fase6");
                break;
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
