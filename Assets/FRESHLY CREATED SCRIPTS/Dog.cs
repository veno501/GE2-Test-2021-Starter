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
}
