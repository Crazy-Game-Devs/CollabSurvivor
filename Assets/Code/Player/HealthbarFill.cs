using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HealthbarFill : MonoBehaviour
{
    public float maxHealth = 100;
    public float playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            playerHealth -= 5;
            Debug.Log("outch");
        }


        float newX = Mathf.Clamp(playerHealth / maxHealth, 0, 1);

        transform.localScale = new Vector3(newX, transform.localScale.y, transform.localScale.z);

        transform.localPosition = new Vector3(-transform.parent.localScale.x / 2 + (newX / 2), 0, -0.1f);

    }
}
