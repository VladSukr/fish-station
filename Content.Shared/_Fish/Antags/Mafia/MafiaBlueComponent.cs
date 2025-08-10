using Content.Shared.StatusIcon;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._Fish.Antags.MafiaBlue
{
    [RegisterComponent, NetworkedComponent]
    public sealed partial class MafiaBlueComponent : Component
    {
        [DataField, ViewVariables(VVAccess.ReadWrite)]
        public ProtoId<FactionIconPrototype> StatusIcon { get; set; } = "MafiaBlueFaction";
    }

}
