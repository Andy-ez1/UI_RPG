using UnityEngine;

public class Enemy : Character
{
    [SerializeField] protected float minDamage, maxDamage;
    public Sprite enemyImage;

    public override void Attack(Character toHit)
    {
        float damage = Random.Range(minDamage, maxDamage) * DamageMultiplier;
        DamageMultiplier = 1f; // Reset pēc uzbrukuma
        toHit.GetHit(damage);
        Debug.Log(CharName + " attacks the player!");
    }

    public void Reset()
    {
        Health = maxHealth;
        DamageMultiplier = 1f;
    }
}