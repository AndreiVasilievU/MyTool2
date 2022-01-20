using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyTool
{
    public static class Tool
    {
        public static void AddXPosition(this Transform t, float x)
        {
            t.position += new Vector3(x, 0, 0);
        }
    }
}

