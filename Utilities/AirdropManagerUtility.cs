using RestoreMonarchy.AirdropManager.Models;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RestoreMonarchy.AirdropManager.Utilities
{
    public static class AirdropManagerUtility
    {
        public static string ToPrettyFormat(this TimeSpan span)
        {
            if (span <= TimeSpan.Zero) return string.Empty;

            var sb = new StringBuilder();
            if (span.Hours > 0)
                sb.AppendFormat("{0} часов ", span.Hours);
            if (span.Minutes > 0)
                sb.AppendFormat("{0} минут ", span.Minutes);
            if (span.Seconds > 0)
                sb.AppendFormat("{0} секунд ", span.Seconds);

            return sb.ToString().TrimEnd(' ');
        }

        public static string ToRich(this string value)
        {
            return value.Replace('{', '<').Replace('}', '>');
        }

        public static void AddAirdropSpawn(AirdropSpawn spawn)
        {
            var field = typeof(LevelManager).GetField("airdropNodes", BindingFlags.Static | BindingFlags.NonPublic);
            List<AirdropNode> nodes = field.GetValue(null) as List<AirdropNode>;

            AddAirdropToNodes(nodes, spawn);
            field.SetValue(null, nodes);
        }

        public static void AddAirdropToNodes(List<AirdropNode> nodes, AirdropSpawn spawn)
        {
            if (spawn.AirdropId == 0)
                nodes.Add(new AirdropNode(spawn.Position.ToVector()));
            else
                nodes.Add(new AirdropNode(spawn.Position.ToVector(), spawn.AirdropId));
        }
    }
}
