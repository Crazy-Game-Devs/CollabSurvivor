using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerStats : BaseCharakterStats
{
	[SerializeField]
	private int maxWeaponAmount;

    [SerializeField]
    private float attack;

    // getter setter
    public int MaxWeaponAmount { get => maxWeaponAmount; protected set => maxWeaponAmount = value; }
}
