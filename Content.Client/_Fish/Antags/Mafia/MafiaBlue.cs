// Content.Shared.Mafia.SharedMafiaBlueComponent.cs
using Content.Shared._Fish.Antags.MafiaBlue;
using Content.Shared.StatusIcon;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Mafia;

[RegisterComponent, NetworkedComponent]
public sealed partial class MafiaBlueComponent : Component
{
    [DataField("statusIcon")]
    public ProtoId<FactionIconPrototype> StatusIcon { get; set; } = "MafiaBlueFaction";
}
