// Content.Shared.Mafia.SharedMafiaRedComponent.cs
using Content.Shared._Fish.Antags.MafiaRed;
using Content.Shared.StatusIcon;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Mafia;

[RegisterComponent, NetworkedComponent]
public sealed partial class MafiaRedComponent : Component
{
    [DataField("statusIcon")]
    public ProtoId<FactionIconPrototype> StatusIcon { get; set; } = "MafiaRedFaction";
}
