using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HealthbarFill : MonoBehaviour
{
    private BasePlayerStats basePlayerStats;

    // Start is called before the first frame update
    void Start()
    {
        basePlayerStats = GameObject.Find("Player").gameObject.GetComponent<BasePlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        float newX = Mathf.Clamp(basePlayerStats.Health / basePlayerStats.MaxHealth, 0, 1);

        transform.localScale = new Vector3(newX, transform.localScale.y, transform.localScale.z);

        transform.localPosition = new Vector3(-transform.parent.localScale.x / 2 + (newX / 2), 0, -0.1f);
    }
}
