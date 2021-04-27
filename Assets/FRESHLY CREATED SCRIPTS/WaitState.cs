using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitState : State
{
    public override void Enter() {
        Player.instance.mostInterestingBallThrown = null;
    }
    public override void Exit() {

    }
    public override void Think() {
        if (Player.instance.mostInterestingBallThrown != null)
        {
            // drop ball
            owner.ChangeState(new ToBallState());
        }
    }
}
