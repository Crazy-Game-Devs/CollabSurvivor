using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyCritValues : MonoBehaviour, IPassiveItem
{
    [SerializeField]
    [Tooltip("Crit chance in percentage")]
    private float critChance = 2;

    [SerializeField]
    [Tooltip("Crit damage in percentage")]
    private float critDamage = 10;
    public bool OnEquip()
    {
        BasePlayerStats stats = GameObject.Find("Player").GetComponent<BasePlayerStats>();
        stats.CritChance *= 1 + critChance / 100;
        stats.CritDamage *= 1 + critDamage / 100;

        return true;
    }
}
