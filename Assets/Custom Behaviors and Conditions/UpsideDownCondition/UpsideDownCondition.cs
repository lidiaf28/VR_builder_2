using System.Runtime.Serialization;
using VRBuilder.Core.Conditions;
using VRBuilder.Core;
using VRBuilder.Core.Attributes;

[DataContract(IsReference = true)]
[HelpLink("https://www.mindport.co/vr-builder-tutorials/creating-custom-conditions")]
public class UpsideDownCondition : Condition<UpsideDownConditionData>
{
    public override IStageProcess GetActiveProcess()
    {
        // Always return a new instance.
        return new UpsideDownConditionActiveProcess(Data);
    }

    protected override IAutocompleter GetAutocompleter()
    {
        // Always return a new instance.
        return new UpsideDownConditionAutocompleter(Data);
    }

    public UpsideDownCondition()
    {
        Data.Name = "Upside Down";
    }
}