using System.Collections.Generic;
using UnityEngine;
using Yosoft.Core;
using Yosoft.Core.Attributes;

namespace Yosoft.Runner
{
    public class Runner: MonoBehaviour
    {
        [SerializeField] public NivelMundo NivelMundoActual;
        [ReadOnly] public int id;
        [SerializeField] public int NumeroNivel;
        [SerializeField] public int MaxPuntaje;
        [SerializeField] public float Frecuencia;
        [SerializeField] public Movimiento MovimientoPorDefecto;
        [SerializeField] public List<IteraccionRunner> Iteraciones;
    }
}