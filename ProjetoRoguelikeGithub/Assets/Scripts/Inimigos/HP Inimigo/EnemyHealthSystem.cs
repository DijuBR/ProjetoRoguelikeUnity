using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy Health" ,menuName = "EnemySystem/Enemy Health")]
public class EnemyHealthSystem : ScriptableObject
{
    public float vidaAtual;
    public float vidaIni;
    public float vidaMax;
}
