using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyDefence : MonoBehaviour, IPassiveItem
{
    [SerializeField]
    private float bonusDefence = 1;
    public bool OnEquip()
    {
        BasePlayerStats stats = GameObject.Find("Player").GetComponent<BasePlayerStats>();
        stats.Defence += bonusDefence;

        return true;
    }
}
