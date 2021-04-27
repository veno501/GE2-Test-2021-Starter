using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToPlayerState : State
{
    // Arrive arriveBehaviour;

    public override void Enter() {
        owner.GetComponent<Arrive>().weight = 1.0f;
    }
    public override void Exit() {
        owner.GetComponent<Arrive>().weight = 0.0f;
    }
    public override void Think() {
        owner.GetComponent<Arrive>().targetPosition = Player.instance.transform.position
            + Player.instance.transform.forward * 10f;

        if (Vector3.Distance(owner.transform.position, owner.GetComponent<Arrive>().targetPosition) <= 1f)
        {
            // drop ball
            owner.ChangeState(new WaitState());
        }
    }
}
