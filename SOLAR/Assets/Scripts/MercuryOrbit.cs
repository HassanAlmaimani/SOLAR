using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercuryOrbit : MonoBehaviour
{
    [Tooltip("Distance from the Sun")]
    public float radius = 5f;

    [Tooltip("Degrees per second")]
    public float speed = 10f;

    public Transform sun;          // drag the Sun here in the Inspector

    private float angle;

    void Start()
    {
        if (sun == null)           // safety: auto-find if you forgot to drag
            sun = GameObject.FindWithTag("Sun").transform;
    }

    void Update()
    {
        angle += speed * Time.deltaTime;
        angle = Mathf.Repeat(angle, 360f);

        float rad = angle * Mathf.Deg2Rad;
        Vector3 offset = new Vector3(
            Mathf.Cos(rad) * radius,
            0,
            Mathf.Sin(rad) * radius);

        transform.position = sun.position + offset;   // <-- relative orbit
    }
}
