using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private BasePlayerStats stats;

    [SerializeField]
    private GameObject userView;

    [SerializeField]
    private Vector2 mapSize = new(30f, 30f);

    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<BasePlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Vector2.zero;
        input.y = Input.GetAxisRaw("Vertical");
        input.x = Input.GetAxisRaw("Horizontal");
        input = stats.MoveSpeed * Time.deltaTime * input.normalized;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x + input.x, -mapSize.x, mapSize.x), Mathf.Clamp(transform.position.y + input.y, -mapSize.y, mapSize.y), transform.position.z);

        userView.transform.position = new Vector3(transform.position.x, transform.position.y, userView.transform.position.z);
    }
}
