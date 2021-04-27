using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToBallState : State
{
    public void Enter() {
        owner.GetComponent<Arrive>().weight = 1.0f;
        owner.GetComponent<Arrive>().targetGameObject = Player.instance.mostInterestingBallThrown;
    }
    public void Exit() {
        owner.GetComponent<Arrive>().weight = 0.0f;
    }
    public void Think() {
        if (Vector3.Distance(owner.transform.position, owner.GetComponent<Arrive>().targetGameObject.transform.position) <= 10f)
        {
            // drop ball
            owner.ChangeState(new WaitState());
        }
    }
}
