using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToBallState : State
{
    public override void Enter() {
        owner.GetComponent<Arrive>().weight = 1.0f;
        owner.GetComponent<Arrive>().targetGameObject = Player.instance.mostInterestingBallThrown;
    }
    public override void Exit() {
        owner.GetComponent<Arrive>().weight = 0.0f;
    }
    public override void Think() {
        if (Vector3.Distance(owner.transform.position, owner.GetComponent<Arrive>().targetGameObject.transform.position) <= 1f)
        {
            // drop ball
            owner.ChangeState(new WaitState());
        }
    }
}
