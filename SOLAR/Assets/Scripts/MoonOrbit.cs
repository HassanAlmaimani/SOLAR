using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    [Tooltip("Distance from the Earth")]
    public float radius = 2f;

    [Tooltip("Degrees per second")]
    public float speed = 10f;

    public Transform Earth;          // drag the Earth here in the Inspector

    private float angle;

    void Start()
    {
        if (Earth == null)           // safety: auto-find if you forgot to drag
            Earth = GameObject.FindWithTag("Earth").transform;
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

        transform.position = Earth.position + offset;   // <-- relative orbit
    }
}