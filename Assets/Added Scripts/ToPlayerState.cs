using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToPlayerState : State
{
    Arrive arrive;

    public override void Enter() {
        arrive = owner.GetComponent<Arrive>();

        // Vector3 newTarget = Player.instance.transform.position + Player.instance.transform.forward*10f;
        // newTarget.y = 0f;
        // arrive.targetPosition = newTarget;
    }
    public override void Exit() {
        owner.GetComponent<Dog>().Drop();
    }
    public override void Think() {
        Vector3 newTarget = Player.instance.transform.position + Player.instance.transform.forward*10f;
        newTarget.y = 0f;
        arrive.targetPosition = newTarget;

        if (Vector3.Distance(owner.transform.position, arrive.targetPosition) <= 2f)
        {
            owner.ChangeState(new WaitState());
        }
    }
}
