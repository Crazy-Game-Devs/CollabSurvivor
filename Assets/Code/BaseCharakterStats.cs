using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharakterStats : MonoBehaviour
{
	[SerializeField]
	private float health = 100;
	[SerializeField]
	private float maxHealth = 100;
	[SerializeField]
	private float moveSpeed = 1;

	// Getter Setter
	public float Health { get => health; protected set { health = value; } }
	public float MaxHealth { get => maxHealth; set => maxHealth = value; }
	public float MoveSpeed { get => moveSpeed;  set => moveSpeed = value; }


	public void reciveDamage(float damage)
	{
		this.Health -= damage;
	}

}
