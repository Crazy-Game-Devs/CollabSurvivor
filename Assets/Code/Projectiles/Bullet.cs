using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : BaseProjectileStats
{
    BasePlayerStats playerStats;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<BasePlayerStats>();
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Getroffen du noob!");

        // Deal damage if bullet collides with an enemy
        if (collision.collider.TryGetComponent(out BaseEnemyStats enemyStats))
        {
            enemyStats.reciveDamage(playerStats.CalcTotalDamage(30));
            Debug.Log(enemyStats.Health);
        } 
        else
        {
            Debug.Log("No enemey");
        }
    }
}
