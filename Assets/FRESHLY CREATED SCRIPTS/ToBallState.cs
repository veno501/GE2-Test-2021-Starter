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
        owner.GetComponent<Arrive>().targetGameObject = null;
    }
    public override void Think() {
        if (Vector3.Distance(owner.transform.position, owner.GetComponent<Arrive>().targetPosition) <= 1f)
        {
            // drop ball
            owner.ChangeState(new ToPlayerState());
        }
    }
}
