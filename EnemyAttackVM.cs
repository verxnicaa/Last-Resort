using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackVM : MonoBehaviour
{
    PlayerHealthVM target;
    [SerializeField] float damage = 40;


    void Start()
    {
        target = FindObjectOfType<PlayerHealthVM>();
    }

    public void AttackHitEvent()
    {
        if (target == null) return;
        target.TakeDamage(damage);
        target.GetComponent<DisplayDamageVM>().ShowDamageImpact();
    }
}
