using System.Collections.Generic;
using UnityEngine;
using Yosoft.Core.Attributes;

namespace Yosoft.Runner
{
    public class IteraccionRunner: MonoBehaviour
    {
        public string name;
        [ReadOnly] public int id;
        [SerializeField] public float Delay;
        [SerializeField] public List<ColumnaRunner> Columnas;
        // public TipoIteracion Tipo;
    }

}