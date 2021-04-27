using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitState : State
{
    public void Enter() {
        Player.instance.mostInterestingBallThrown = null;
    }
    public void Exit() {

    }
    public void Think() {
        if (Player.instance.mostInterestingBallThrown != null)
        {
            // drop ball
            owner.ChangeState(new ToBallState());
        }
    }
}
