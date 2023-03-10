using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyStats : BaseCharakterStats
{
    [SerializeField]
    private float contactDamage = 10;

    [SerializeField]
    [Tooltip("Number of hits per second")]
    private float contactDamageSpeed = 1;

    [SerializeField]
    private Color color = Color.red;

    [SerializeField]
    private Renderer updateColor;

    // Getter Setter
    public float ContactDamage { get => contactDamage; protected set => contactDamage = value; }
    public float ContactDamageSpeed { get => contactDamageSpeed; protected set => contactDamageSpeed = value; }
    public Color Color { get => color; set => color = value; }
    public Renderer UpdateColor { get => updateColor; set => updateColor = value; }
}
