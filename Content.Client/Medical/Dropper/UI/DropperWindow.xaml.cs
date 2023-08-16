using System;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Input;
using Range = Robust.Client.UserInterface.Controls.Range;

namespace Content.Client.Medical.Dropper.UI
{
    /// <summary>
    /// Client-side UI used to control a dropper.
    /// </summary>
    [GenerateTypedNameReferences]
    public sealed partial class DropperWindow : DefaultWindow
    {
        private readonly ButtonGroup _buttonGroup = new();

        public DropperWindow()
        {
            RobustXamlLoader.Load(this);

        }


    }
}
