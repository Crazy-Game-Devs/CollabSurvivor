using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    GameObject player;
    BaseEnemyStats baseEnemyStats;
    BasePlayerStats basePlayerStats;

    private float lastHitTimestamp = 0;

    void Start()
    {
        player = GameObject.Find("Player");
        basePlayerStats = GameObject.Find("Player").GetComponent<BasePlayerStats>();
        baseEnemyStats = this.GetComponent<BaseEnemyStats>();
    }

    /// <summary>
    /// Manage collisions
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionStay2D(Collision2D collision)
    {
        GameObject collisionObject = collision.collider.gameObject;
        
        // Deal contact damage if colliding with player
        if(collisionObject.Equals(player))
        {
            if (lastHitTimestamp >= Time.time - (1 / baseEnemyStats.ContactDamageSpeed)) return;
            basePlayerStats.reciveDamage(baseEnemyStats.ContactDamage);
            lastHitTimestamp = Time.time;
        }
    }
}
