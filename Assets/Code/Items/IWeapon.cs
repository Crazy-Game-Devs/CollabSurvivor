using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon : IBaseItem
{
    public bool OnAttackmove();
}
