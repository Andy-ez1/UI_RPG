using UnityEngine;

public class MageEnemy : Enemy
{
    [SerializeField] private float spellDamage = 12f;
    [SerializeField] private float selfHealAmount = 3f;
    
    public override void Attack(Character toHit)
    {
        float damage = spellDamage * DamageMultiplier;
        DamageMultiplier = 1f;
        toHit.GetHit(damage);
        Health += selfHealAmount; 
        Debug.Log(CharName + " casts a spell and self-heals " + selfHealAmount + " HP!");
    }
}