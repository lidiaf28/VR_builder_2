using System.Collections;
using UnityEngine;
using VRBuilder.Core;

public class UpsideDownConditionActiveProcess : StageProcess<UpsideDownConditionData>
{
    public override void Start()
    {
    }

    public override IEnumerator Update()
    {
        // Get the difference between vector pointing down,
        // And the vector that comes out of the "roof" of the target.
        // Then compare it with threshold from data.
        while (Vector3.Angle(Vector3.down, Data.Target.Value.GameObject.transform.up) > Data.Threshold)
        {
            //If the angle is more than threshold, wait for the next frame.
            yield return null;
        }

        // If the angle is less or equal to threshold, mark the condition as complete.
        Data.IsCompleted = true;
    }

    public override void End()
    {
    }

    // Nothing to fast-forward.
    // We will explain it soon.
    public override void FastForward()
    {
    }

    // Declare the constructor. It calls the base method to bind the data object with the process.
    public UpsideDownConditionActiveProcess(UpsideDownConditionData data) : base(data)
    {
    }
}