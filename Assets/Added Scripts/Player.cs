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
    public AudioSource jazzMusic;
    bool isJazzy;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (canThrow && Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ob = Instantiate(ball, transform.position + transform.forward, Quaternion.LookRotation(Random.insideUnitSphere));
            ob.transform.forward = transform.forward;
            ob.GetComponent<Rigidbody>().AddForce(transform.forward * throwStrength, ForceMode.Impulse);
            mostInterestingBallThrown = ob;
            canThrow = false;
        }
    }

    public void CommenceTheJazz()
    {
        if (!isJazzy)
        {
            isJazzy = true;
            jazzMusic.gameObject.SetActive(true);
            // jazzMusic.Play();
            jazzMusic.time += 34.7f;
        }
    }
}
