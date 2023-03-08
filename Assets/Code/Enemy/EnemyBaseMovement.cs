using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1.0f;
    Transform playerPosition;



    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = playerPosition.position - transform.position;
        newPosition.Normalize();
        transform.position += newPosition * moveSpeed * Time.deltaTime;
    }
}
