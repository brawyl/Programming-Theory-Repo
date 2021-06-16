using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class BlueRacer : Racer
{
    // ENCAPSULATION
    public override string racerName { get { return "blue"; } }
    public override string description { get { return "This racer is a blue ball. \n\nspeed: " + this.speed + "\nluck: " + this.luck; } }
    public override float speed { get { return 20f; } }
    public override float luck { get { return 50f; } }

    // POLYMORPHISM
    public override void LuckyBoost()
    {
        float randomNumber = Random.Range(0f, 100f);
        if (randomNumber <= luck)
        {
            Accelerate();
        }
    }
}
