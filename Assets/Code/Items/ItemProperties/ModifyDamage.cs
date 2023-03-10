using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ModifyDamage : MonoBehaviour, IPassiveItem
{
    [SerializeField]
    private float bonusDamage = 1;

    [SerializeField]
    private float bonusPercentageDamage = 10;
    public bool OnEquip()
    {
        BasePlayerStats stats = GameObject.Find("Player").GetComponent<BasePlayerStats>();
        stats.Damage += bonusDamage;
        stats.DamagePercentage *= bonusPercentageDamage;

        return true;
    }
}
