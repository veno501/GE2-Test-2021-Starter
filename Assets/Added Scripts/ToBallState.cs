using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToBallState : State
{
    GameObject ball;
    Arrive arrive;

    public override void Enter() {
        arrive = owner.GetComponent<Arrive>();
        ball = Player.instance.mostInterestingBallThrown;
    }
    public override void Exit() {
        owner.GetComponent<Dog>().Pickup(ball);
    }
    public override void Think() {
        arrive.targetPosition = new Vector3(ball.transform.position.x, 0f, ball.transform.position.z);

        if (Vector3.Distance(owner.transform.position, arrive.targetPosition) <= 2f)
        {
            owner.ChangeState(new ToPlayerState());
        }
    }
}
