using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitState : State
{
    Boid boid;

    public override void Enter() {
        Player.instance.canThrow = true;

        boid = owner.GetComponent<Boid>();
        boid.force = Vector3.zero;
        boid.acceleration = Vector3.zero;
        boid.velocity = Vector3.zero;
        boid.enabled = false;

        // press to add Jazz
        Player.instance.CommenceTheJazz();
    }
    public override void Exit() {
        boid.enabled = true;
    }
    public override void Think() {
        Vector3 pos = Player.instance.transform.position - owner.transform.position;
        pos.y = 0;
        Quaternion newRot = Quaternion.LookRotation(pos.normalized, Vector3.up);
        owner.transform.rotation = Quaternion.Lerp(owner.transform.rotation, newRot, Time.deltaTime * 3.0f);

        if (Player.instance.canThrow == false)
        {
            owner.ChangeState(new ToBallState());
        }
    }
}
