using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyRange : MonoBehaviour, IPassiveItem
{
    [SerializeField]
    private float bonusRange = 5;
    public bool OnEquip()
    {
        BasePlayerStats stats = GameObject.Find("Player").GetComponent<BasePlayerStats>();
        stats.Range += bonusRange;

        return true;
    }
}
