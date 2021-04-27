using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    StateMachine stateMachine;
    [HideInInspector]
    public GameObject ball;
    void Start()
    {
        stateMachine = GetComponent<StateMachine>();
        stateMachine.ChangeState(new ToPlayerState());
    }

    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
        transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
    }
}
