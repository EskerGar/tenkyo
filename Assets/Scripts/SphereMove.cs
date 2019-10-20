using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    private float g = 15f;

    void FixedUpdate()
    {
        var rb = GetComponent<Rigidbody>();
        // normalize axis
        /*Physics.gravity = new Vector3(
            Input.acceleration.x,
            Input.acceleration.z,
            Input.acceleration.y
        ) * g;*/
        Vector3 dir = Input.acceleration;
        rb.velocity = new Vector3(dir.x, -1f, dir.y) * g;
    }
}
