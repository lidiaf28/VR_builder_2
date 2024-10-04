using System.Runtime.Serialization;
using UnityEngine;
using VRBuilder.Core;
using VRBuilder.Core.Attributes;
using VRBuilder.Core.Behaviors;
using VRBuilder.Core.SceneObjects;

[DataContract(IsReference = true)]
[HelpLink("https://www.mindport.co/vr-builder-tutorials/creating-custom-behaviors")]
public class ScalingBehavior : Behavior<ScalingBehaviorData>
{
    // Any serializable class must include a public parameterless constructor.
    // (Classes with no declared constructors have one by default).
    // Setup the Data property here.
    public ScalingBehavior()
    {
        // The default base constructor has created the Data object already.
        // Now we need to setup its values.
        Data.Duration = 0f;
        Data.TargetScale = Vector3.one;
        // Make sure to always initialize scene object references.
        Data.Target = new SceneObjectReference("");
    }

    // Each entity has three virtual methods where you can declare the stage process
    // that that entity should use.
    // By default, these methods return empty processes that do nothing.
    public override IStageProcess GetActivatingProcess()
    {
        // Always return a new instance of a stage process.
        return new ScalingBehaviorActivatingProcess(Data);
    }
}
