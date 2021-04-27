using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitState : State
{
    public override void Enter() {
        Player.instance.mostInterestingBallThrown = null;
        Player.instance.canThrow = true;
    }
    public override void Exit() {
        Player.instance.canThrow = false;
    }
    public override void Think() {
        if (Player.instance.mostInterestingBallThrown != null)
        {
            // drop ball
            owner.ChangeState(new ToBallState());
        }
    }
}
