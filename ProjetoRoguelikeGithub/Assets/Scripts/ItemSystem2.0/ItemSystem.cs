using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

[System.Serializable]
public abstract class ItemSystem
{
    public abstract string GiveName();
    public virtual void OnHit(PlayerStatus status, VidaInimigo inimigo, int stack)
    {

    }
   public virtual void Update(PlayerStatus status, int stack)
   {

   }

}
public class HealingItem : ItemSystem
{
    public override string GiveName()
    {
        return "Healing Item";
    }

    public override void Update(PlayerStatus status, int stack)
    {
        status.vida += 0.5f + (0.5f * stack);
    }
}
public class FireDamageItem : ItemSystem
{
    public override string GiveName()
    {
        return "Fire Damage Item";
    }
    public override void OnHit(PlayerStatus status, VidaInimigo inimigo, int stack)
    {
        inimigo.vidaInimigo -= 0.2f * stack;
    }
}