using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseProjectile : MonoBehaviour
{
    [SerializeField]
    private float projectileSpeed = 5f;
    [SerializeField]
    private float damage = 5f;
    [SerializeField]
    private Vector2 direction;

    public float ProjectileSpeed { get => projectileSpeed; protected set { projectileSpeed = value; } }
    public float Damage { get => damage; protected set { damage = value; } }
    public Vector2 Direction { get => direction; protected set { direction = value; } }
}
