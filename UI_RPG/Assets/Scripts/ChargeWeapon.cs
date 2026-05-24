using UnityEngine;

public class ChargeWeapon : Weapon
{
    [SerializeField] private float chargeIncrement = 0.5f;
    private float charge = 0;

    public override float GetDamage()
    {
        float damage = baseDamage + charge;
        charge += chargeIncrement;
        return damage;
    }

    public override void ApplyEffect(Character target)
    {
        Debug.Log("Charge level: " + charge);
    }

    public void ResetCharge() => charge = 0;
}