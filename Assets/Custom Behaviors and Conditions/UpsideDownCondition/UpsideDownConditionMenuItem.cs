using VRBuilder.Core.Conditions;
using VRBuilder.Editor.UI.StepInspector.Menu;

public class UpsideDownConditionMenuItem : MenuItem<ICondition>
{
    public override string DisplayedName => "Tutorial/Object Upside Down";

    public override ICondition GetNewItem()
    {
        return new UpsideDownCondition();
    }
}
