using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalBoss : MonoBehaviour
{
    public GameObject texto;
    public GameObject boss;
    private bool concluido;
    [SerializeField] private Animator portalBoss;
    private bool bossMorto;
    
    // Start is called before the first frame update
    void Start()
    {
        texto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("PlayerTeste").GetComponent<PlayerStatus>().vida == 3) //precisamos mudar essa condição, pois a anterior era a pontuação e o score que foram removidos
        {
            portalBoss.Play("Sobe");
            concluido = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && concluido == true)
        {
            SceneManager.LoadScene("Creditos");
        }
    }
    public void EventoPlay()
    {
        texto.SetActive(true);
    }
}
