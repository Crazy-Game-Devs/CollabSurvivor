using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modify : MonoBehaviour, IPassiveItem
{
    [SerializeField]
    private float bonusCameraZoom = 1f;
    public bool OnEquip()
    {
        BasePlayerStats stats = GameObject.Find("Player").GetComponent<BasePlayerStats>();
        stats.CameraZoom += bonusCameraZoom;

        return true;
    }
}
