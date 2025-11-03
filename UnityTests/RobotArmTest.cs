using NUnit.Framework;
using Unity.VisualScripting;

public class RobotArmTests
{
    // This tests if a new RobotArm starts with an attached arm.
    [Test]
    public void ArmStartsAttached()
    {
        var arm = new RobotArm(); //create new RobotArm
        Assert.IsTrue(arm.IsAttached); //Check
    }

    //This tests if after detaching, IsAttached is false. 
    [Test]
    public void CanDetachArm()
    {
        var arm = new RobotArm(); //create new RobotArm
        arm.Detach(); // Call the Detach method
        Assert.IsFalse(arm.IsAttached); //Check if IsAttached is false
    }
}