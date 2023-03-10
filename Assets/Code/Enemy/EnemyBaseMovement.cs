using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBaseMovement : MonoBehaviour
{
    private BaseEnemyStats enemyStats;
    private Transform playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.Find("Player").GetComponent<Transform>();
        enemyStats = GetComponent<BaseEnemyStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyStats.Health > 0) 
        { 
            Vector3 newPosition = playerPosition.position - transform.position;
            newPosition.Normalize();
            transform.position += enemyStats.MoveSpeed * Time.deltaTime * newPosition;
        } 
        else
        {
            enemyStats.Color = Color.gray;
        }
    }
}
