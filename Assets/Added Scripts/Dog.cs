using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    StateMachine stateMachine;
    [HideInInspector]
    public Transform ball;
    public Transform ballAttach;
    void Start()
    {
        stateMachine = GetComponent<StateMachine>();
        stateMachine.ChangeState(new ToPlayerState());
    }

    public void Pickup(GameObject _ball)
    {
        ball = _ball.transform;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    public void Drop()
    {
        ball = null;
    }

    void LateUpdate()
    {
        if (ball) {
            ball.position = ballAttach.position;
            ball.forward = transform.forward;
        }
    }
}
