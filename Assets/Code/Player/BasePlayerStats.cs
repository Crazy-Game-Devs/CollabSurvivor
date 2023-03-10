using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerStats : BaseCharakterStats
{
	[SerializeField]
	private int maxWeaponAmount;

    [SerializeField]
    private float damage;

    [SerializeField] 
    private float damagePercentage;

    [SerializeField]
    private float defence;

    [SerializeField]
    private float critChance;

    [SerializeField]
    private float critDamage;

    [SerializeField]
    private float range;

    [SerializeField]
    private float playerSize;

    [SerializeField]
    private float cameraZoom;

    // getter setter
    public int MaxWeaponAmount { get => maxWeaponAmount; set => maxWeaponAmount = value; }
    public float Damage { get => damage; set => damage = value; }
    public float Defence { get => defence; set => defence = value; }
    public float CritChance { get => critChance; set => critChance = value; }
    public float CritDamage { get => critDamage; set => critDamage = value; }
    public float Range { get => range; set => range = value; }
    public float PlayerSize { get => playerSize; set => playerSize = value; }
    public float CameraZoom { get => cameraZoom; set => cameraZoom = value; }
    public float DamagePercentage { get => damagePercentage; set => damagePercentage = value; }
    public float CalcTotalDamage(float weaponDamage) 
    {
        return (damage + weaponDamage) * (1 + damagePercentage / 100);
    }
}
