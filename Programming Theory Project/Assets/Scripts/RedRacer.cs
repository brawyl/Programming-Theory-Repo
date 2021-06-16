using System.Collections;
using System.Collections.Generic;

public class RedRacer : Racer
{
    public override string racerName { get { return "red"; } }
    public override string description { get { return "This racer is a red ball. \n\nspeed: " + this.speed + "\nluck: " + this.luck; } }
    public override float speed { get { return 24f; } }
    public override float luck { get { return 30f; } }
}
