using System.Runtime.Serialization;
using VRBuilder.Core;
using VRBuilder.Core.Attributes;
using VRBuilder.Core.Conditions;
using VRBuilder.Core.SceneObjects;

[DataContract(IsReference = true)]
[DisplayName("Is Object Upside Down?")]
public class UpsideDownConditionData : IConditionData
{
    // A reference to the target object that we will check.
    [DataMember]
    public SceneObjectReference Target { get; set; }

    // We will check how far the target from being upside down in degrees.
    // If the difference is lower than threshold, we must complete the condition.
    [DataMember]
    public float Threshold { get; set; }

    public Metadata Metadata { get; set; }
    public string Name { get; set; }
    public bool IsCompleted { get; set; }

    public UpsideDownConditionData()
    {
        Target = new SceneObjectReference("");
        Threshold = 135f;
    }
}