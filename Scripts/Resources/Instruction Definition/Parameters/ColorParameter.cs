using Godot;

namespace Rusty.Cutscenes
{
    /// <summary>
    /// A definition for a color instruction parameter.
    /// </summary>
    [Tool]
    [GlobalClass]
    public sealed partial class ColorParameter : Parameter
    {
        /* Public properties. */
        [Export] public override string ID { get; protected set; } = "";
        [Export] public override string DisplayName { get; protected set; } = "";
        [Export(PropertyHint.MultilineText)] public override string Description { get; protected set; } = "";

        /// <summary>
        /// The default value of this parameter in the editor.
        /// </summary>
        [Export] public Color DefaultValue { get; private set; } = Colors.White;

        /* Constructors. */
        public ColorParameter() : base() { }

        public ColorParameter(string id, string displayName, string description, Color defaultValue)
            : base(id, displayName, description)
        {
            DefaultValue = defaultValue;
        }

        /* Public methods. */
        public override string ToString()
        {
            return $"{ID} (color)";
        }
    }
}
