using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Somewhere.Isolated
{
    public static class ColorfulExtensions
    {
        public static string Red(this object self)
        {
            return "<color=red>" + self + "</color>";
        }

        public static string Green(this object self)
        {
            return "<color=green>" + self + "</color>";
        }

        public static string Blue(this object self)
        {
            return "<color=blue>" + self + "</color>";
        }
    }
}
