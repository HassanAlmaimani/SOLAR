using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Put this on any planet (or moon, asteroid, etc.).
/// Spins the object around its local Y-axis (equator).
/// Speed can be set in the Inspector or changed from other scripts.
/// </summary>
public class PlanetSpin : MonoBehaviour
{
    [Header("Degrees per second")]
    [SerializeField] float ySpeed = 30f;   // spin around equator (local Y)
    [SerializeField] float xSpeed = 5f;    // tumble/wobble (local X)


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // order doesn’t matter for infinitesimal steps
        transform.Rotate(Vector3.up, ySpeed * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.right, xSpeed * Time.deltaTime, Space.Self);
    }

    // runtime helpers
    public void SetYSpeed(float s) => ySpeed = s;
    public void SetXSpeed(float s) => xSpeed = s;
}
