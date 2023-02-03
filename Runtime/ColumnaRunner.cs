using System;
using System.Collections.Generic;
using UnityEngine;

namespace Yosoft.Runner
{
    [Serializable]
    public class ColumnaRunner: MonoBehaviour
    {
        public string name;
        public int id;
        public float Delay;
        public List<Runner_SO.Spawn> Spawners;
    }
}