using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;

namespace RageMP_Server.Admin
{
    class Commands : Script
    {
        [Command("createcar")]
        public void CMD_SpwanCar(Client player, string vehcile_name)
        {
            uint hash = NAPI.Util.GetHashKey(vehcile_name);

            Vehicle vehicle = NAPI.Vehicle.CreateVehicle(hash, player.Position.Around(5), 0, 0, 0);

            player.TriggerEvent("vec", vehicle);

            player.SendNotification($"~g~Du hast ein {vehicle.DisplayName} gespawnd");
        }

        [Command("healme")]
        public void CMD_WTP(Client player)
        {
            player.Health += 20;
        }

        [Command("poss")]
        public void CMD_Poss(Client player)
        {
            player.SendNotification($"X: {player.Position.X} Y: {player.Position.Y} Z: {player.Position.Z}");
            Console.WriteLine($"X: { player.Position.X} Y: { player.Position.Y} Z: { player.Position.Z}");
        }
    }
}
