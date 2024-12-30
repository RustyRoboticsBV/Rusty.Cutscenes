using Godot;

namespace Rusty.Cutscenes
{
    /// <summary>
    /// Meta-data for an instruction parameter with a string value that does not allow line-breaks.
    /// </summary>
    [Tool]
    [GlobalClass]
    public sealed partial class LineParameter : ParameterDefinition
    {
        /* Public properties. */
        /// <summary>
        /// The default value of this parameter in the editor.
        /// </summary>
        [Export] public string DefaultValue { get; private set; } = "";

        /* Constructors. */
        public LineParameter() : base() { }

        public LineParameter(string id, string displayName, string description, string defaultValue)
            : base(id, displayName, description)
        {
            DefaultValue = defaultValue;
        }

        /* Public methods. */
        public override string ToString()
        {
            return "Text Line: " + Id;
        }
    }
}