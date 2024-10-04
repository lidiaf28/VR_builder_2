using UnityEngine;
using System.Runtime.Serialization;
using VRBuilder.Core;
using VRBuilder.Core.Attributes;
using VRBuilder.Core.Behaviors;
using VRBuilder.Core.SceneObjects;

[DataContract(IsReference = true)]
[DisplayName("Scale Object")]
public class ScalingBehaviorData : IBehaviorData
{
    [DataMember]
    public SceneObjectReference Target { get; set; }

    [DataMember]
    [DisplayName("Target Scale")]
    public Vector3 TargetScale { get; set; }

    [DataMember]
    [DisplayName("Animation Duration")]
    public float Duration { get; set; }

    public Metadata Metadata { get; set; }

    public string Name { get; set; }
}