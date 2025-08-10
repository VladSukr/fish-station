// // Content.Client.Mafia.MafiaSystem.cs
// using Content.Shared._Fish.Antags.Mafia; // теперь клиент увидит MafiaComponent
// using Content.Shared.StatusIcon;         // для GetStatusIconsEvent
// using Robust.Client.GameObjects;
// using Robust.Shared.Prototypes;
// using Content.Shared.StatusIcon.Components;

// namespace Content.Client.Mafia;

// public sealed class MafiaSystem : EntitySystem
// {
//     [Dependency] private readonly IPrototypeManager _prototype = default!;

//     public override void Initialize()
//     {
//         base.Initialize();
//         SubscribeLocalEvent<MafiaComponent, GetStatusIconsEvent>(AddMafiaStatusIcon);
//     }

//     private void AddMafiaStatusIcon(EntityUid uid, MafiaComponent comp, ref GetStatusIconsEvent args)
//     {
//         var icon = _prototype.Index(comp.StatusIcon);
//         args.StatusIcons.Add(icon);
//     }
// }




// namespace Content.Client.Mafia
// {
//     public sealed class MafiaSystem : EntitySystem
//     {
//         [Dependency] private readonly IPrototypeManager _prototype = default!;

//         public override void Initialize()
//         {
//             base.Initialize();
//             SubscribeLocalEvent<MafiaComponent, GetStatusIconsEvent>(AddMafiaStatusIcon);
//         }

//         private void AddMafiaStatusIcon(EntityUid uid, MafiaComponent comp, ref GetStatusIconsEvent args)
//         {
//             var icon = _prototype.Index(comp.StatusIcon);
//             args.StatusIcons.Add(icon);
//         }
//     }
// }
