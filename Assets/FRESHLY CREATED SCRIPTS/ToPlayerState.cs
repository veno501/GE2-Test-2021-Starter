using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToPlayerState : State
{
    // Arrive arriveBehaviour;

    public override void Enter() {
        owner.GetComponent<Arrive>().weight = 1.0f;
        owner.GetComponent<Arrive>().targetGameObject = Player.instance.gameObject;
    }
    public override void Exit() {
        owner.GetComponent<Arrive>().weight = 0.0f;
    }
    public override void Think() {
        if (Vector3.Distance(owner.transform.position, Player.instance.transform.position) <= 1f)
        {
            // drop ball
            owner.ChangeState(new WaitState());
        }
    }
}
