using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : BaseProjectile
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vec = Vector2.zero;
        Vector2 dir = ProjectileSpeed * Time.deltaTime * Direction.normalized;
        vec.x = dir.x + transform.position.x;
        vec.y = dir.y + transform.position.y;

        transform.position = new Vector3(vec.x, vec.y, transform.position.z);
    }
}
