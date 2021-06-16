using System.Collections;
using System.Collections.Generic;

public class GreenRacer : Racer
{
    public override string racerName { get { return "green"; } }
    public override string description { get { return "This racer is a green ball. \n\nspeed: " + this.speed + "\nluck: " + this.luck; } }
    public override float speed { get { return 22f; } }
    public override float luck { get { return 40f; } }
}
