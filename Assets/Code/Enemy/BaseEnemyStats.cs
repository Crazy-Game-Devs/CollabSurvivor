using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyStats : BaseCharakterStats
{
    [SerializeField]
    private float contactDamage;

    // Getter Setter
    public float ContactDamage { get => contactDamage; protected set => contactDamage = value; }
}
