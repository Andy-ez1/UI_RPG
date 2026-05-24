using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] internal float baseDamage;

    public virtual float GetDamage()
    {
        return baseDamage;
    }

    public abstract void ApplyEffect(Character target);
}