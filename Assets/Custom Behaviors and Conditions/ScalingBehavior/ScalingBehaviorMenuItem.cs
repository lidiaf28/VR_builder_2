using VRBuilder.Core.Behaviors;
using VRBuilder.Editor.UI.StepInspector.Menu;

public class ScalingBehaviorMenuItem : MenuItem<IBehavior>
{
    /// <inheritdoc />
    public override string DisplayedName { get; } = "Tutorial/Scale Behavior";

    /// <inheritdoc />
    public override IBehavior GetNewItem()
    {
        return new ScalingBehavior();
    }
}
