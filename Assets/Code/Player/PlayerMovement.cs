using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float playerMovement = 1.0f;
    [SerializeField]
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = Vector2.zero;
        input.y = Input.GetAxisRaw("Vertical");
        input.x = Input.GetAxisRaw("Horizontal");
        input = input.normalized * playerMovement * Time.deltaTime;
        transform.position = new Vector3(transform.position.x + input.x, transform.position.y + input.y, transform.position.z);

        camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
    }
}
