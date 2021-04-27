using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower5000 : MonoBehaviour
{
    [HideInInspector]
    public bool canThrow = true;
    public float throwStrength = 5f;
    public GameObject ball;

    void Update()
    {
        if (canThrow && Input.GetMouseButtonDown(0))
        {
            GameObject ob = Instantiate(ball, transform.position + transform.forward, Quaternion.identity);
            ob.transform.forward = transform.forward;
            ob.GetComponent<Rigidbody>().AddForce(transform.forward * throwStrength, ForceMode.Impulse);
            canThrow = false;
        }
    }
}
