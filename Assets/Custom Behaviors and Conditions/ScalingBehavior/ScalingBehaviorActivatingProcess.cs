using VRBuilder.Core;
using System.Collections;
using UnityEngine;

public class ScalingBehaviorActivatingProcess : StageProcess<ScalingBehaviorData>
{
    private float startedAt;
    private Transform scaledTransform;
    private Vector3 initialScale;

    public override void Start()
    {
        scaledTransform = Data.Target.Value.GameObject.transform;
        startedAt = Time.time;
        initialScale = scaledTransform.localScale;
    }

    public override IEnumerator Update()
    {
        while (Time.time - startedAt < Data.Duration)
        {
            float progress = (Time.time - startedAt) / Data.Duration;

            scaledTransform.localScale = Vector3.Lerp(initialScale, Data.TargetScale, progress);

            yield return null;
        }
    }

    public override void End()
    {
        scaledTransform.localScale = Data.TargetScale;
    }

    public override void FastForward()
    {
    }

    public ScalingBehaviorActivatingProcess(ScalingBehaviorData data) : base(data)
    {
    }
}