using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiggleTail : MonoBehaviour
{
    float t = 0;
    void LateUpdate()
    {
        t += Time.deltaTime * GetComponentInParent<Boid>().velocity.magnitude * 3.0f;
        transform.localRotation = Quaternion.Euler(transform.localRotation.x, Mathf.Sin(t)*22.5f, transform.localRotation.z);
    }
}
