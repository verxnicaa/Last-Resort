﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthVM : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            GetComponent<DeathHandlerVM>().HandleDeath();
        }
    }
}
