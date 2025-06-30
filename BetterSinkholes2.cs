using System;
using CustomPlayerEffects;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events.EventArgs.Player;
using Hazards;
using UnityEngine;

namespace BetterSinkholesUpdated
{
    public class BetterSinkholesUpdated : Plugin<Config>
    {
        public override string Author { get; } = "Konoaru (original by blackruby)";
        public override string Name { get; } = "BetterSinkholesUpdated";
        public override Version Version { get; } = new(1, 1, 0);
        public override Version RequiredExiledVersion { get; } = new(9, 6, 0);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.StayingOnEnvironmentalHazard += OnStayingOnSinkhole;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.StayingOnEnvironmentalHazard -= OnStayingOnSinkhole;
            base.OnDisabled();
        }

        private void OnStayingOnSinkhole(StayingOnEnvironmentalHazardEventArgs ev)
        {
            if (ev.Hazard.Base is not SinkholeEnvironmentalHazard sinkhole)
                return;

            if (ev.Player.IsScp || ev.Player.IsGodModeEnabled)
                return;

            float distance = Vector3.Distance(ev.Player.Position, sinkhole.transform.position);
            if (distance > sinkhole.MaxDistance * Config.TeleportDistance)
                return;

            ev.Player.DisableEffect<Sinkhole>();
            ev.Player.EnableEffect<Corroding>();
            ev.Player.Broadcast(Config.TeleportMessageDuration, Config.TeleportMessage);
            ev.Player.Position = new Vector3(-0.001f, -299.080f, -0.003f);
        }
    }

    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public float TeleportDistance { get; set; } = 0.6f;
        public float SlowDistance { get; set; } = 1.2f;

        public ushort TeleportMessageDuration { get; set; } = 3;
        public string TeleportMessage { get; set; } = "You were swallowed by the anomaly...";
    }
}
