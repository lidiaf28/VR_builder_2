using UnityEngine;
using VRBuilder.Core;

public class UpsideDownConditionAutocompleter : Autocompleter<UpsideDownConditionData>
{
    public UpsideDownConditionAutocompleter(UpsideDownConditionData data) : base(data)
    {
    }

    public override void Complete()
    {
        // Turn the target upside down, as it would normally happen.
        Data.Target.Value.GameObject.transform.rotation = Quaternion.Euler(0, 0, 180f);
    }
}