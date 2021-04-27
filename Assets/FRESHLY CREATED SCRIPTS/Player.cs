using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector]
    public bool canThrow = true;
    [HideInInspector]
    public GameObject mostInterestingBallThrown;
    public float throwStrength = 5f;
    public GameObject ball;
    public static Player instance;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (canThrow && Input.GetMouseButtonDown(0))
        {
            GameObject ob = Instantiate(ball, transform.position + transform.forward, Quaternion.identity);
            ob.transform.forward = transform.forward;
            ob.GetComponent<Rigidbody>().AddForce(transform.forward * throwStrength, ForceMode.Impulse);
            canThrow = false;
            mostInterestingBallThrown = ob;
        }
    }
}
