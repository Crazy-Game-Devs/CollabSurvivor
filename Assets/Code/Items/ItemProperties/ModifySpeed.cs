using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifySpeed : MonoBehaviour, IPassiveItem
{
    [SerializeField]
    private float bonusSpeed = 1;
    public bool OnEquip()
    {
        BasePlayerStats stats = GameObject.Find("Player").GetComponent<BasePlayerStats>();
        stats.MoveSpeed += bonusSpeed;
        
        return true;
    }
}
