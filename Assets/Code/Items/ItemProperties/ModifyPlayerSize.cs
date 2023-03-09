using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyPlayerSize : MonoBehaviour, IPassiveItem
{
    [SerializeField]
    private float bonusSize = -0.1f;
    public bool OnEquip()
    {
        BasePlayerStats stats = GameObject.Find("Player").GetComponent<BasePlayerStats>();
        stats.PlayerSize += bonusSize;

        return true;
    }
}
