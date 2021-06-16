using System.Collections;
using System.Collections.Generic;

public class BlueRacer : Racer
{
    public override string racerName { get { return "blue"; } }
    public override string description { get { return "This racer is a blue ball. \n\nspeed: " + this.speed + "\nluck: " + this.luck; } }
    public override float speed { get { return 20f; } }
    public override float luck { get { return 50f; } }
}
