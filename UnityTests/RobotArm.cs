public class RobotArm
{
    //Bool to track when the arm is attached. 
    public bool IsAttached { get; private set; }

    //Set to IsAttached to true
    public RobotArm()
    {
        IsAttached = true;
    }

    //On Detach set to false
    public void Detach()
    {
        IsAttached = false;
    }

    //On Attach set to true
    public void Attach()
    {
        IsAttached = true;
    }
}