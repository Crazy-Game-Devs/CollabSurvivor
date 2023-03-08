using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharakterStats : MonoBehaviour
{
    [SerializeField]
    private float health;
    [SerializeField]
    private float maxHealth;
    [SerializeField]
    private float moveSpeed;

    // Getter Setter
    public float Health { get => health; protected set { health = value; } }
    public float MaxHealth { get => maxHealth; protected set { maxHealth = value; } }
    public float MoveSpeed { get => moveSpeed; protected set { moveSpeed = value; } }

}
