using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    
    [Header("Referencias")]
    public scoreScript score;
    public GameObject particula;

    [Header("Variáveis Vida Boss")]
    public float vidaBossInicial;
    public float vidaBoss;
    public float vidaBossMax;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score").GetComponent<scoreScript>();
        vidaBoss = vidaBossInicial + +1.55f * (score.pontuacao);
        vidaBossMax = vidaBoss;
    }

    // Update is called once per frame
    void Update()
    {
        if(vidaBoss <= 0)
        {
            Instantiate(particula, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    private void OnDestroy()
    {
        

    }

    
}
