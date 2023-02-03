using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using Yosoft.Core;
using Yosoft.Core.Attributes;

namespace Yosoft.Runner
{
    [CreateAssetMenu(fileName = "nivelRunner_UI", menuName = "Nivel runnerUI", order = 0)]
    public class RunnerUI_SO : ScriptableObject
    {
        [SerializeField] public NivelMundo NivelMundoActual;
        [ReadOnly] public int id;
        [SerializeField] public int NumeroNivel;
        [SerializeField] public int MaxPuntaje;
        [SerializeField] public float Frecuencia;
        [SerializeField] public Movimiento MovimientoPorDefecto;
        [SerializeField] public List<Iteraccion> Iteraciones;

        [System.Serializable]
        public class Iteraccion
        {
            public string name;
            [ReadOnly] public int id;
            [SerializeField] public float Delay;
            [SerializeField] public List<Spawn> Spawners;
        }

        [System.Serializable]
        public class Spawn
        {
            public string name;
            [ReadOnly] public int id;
            [SerializeField] public TipoSpawn Tipo;
            [SerializeField] public GameObject Prefab;
            [SerializeField] public Vector3 Posicion;
            [SerializeField] public Vector3 Rotacion;
            [SerializeField] public float MinVelocidad;
            [SerializeField] public float MaxVelocidad;
            [SerializeField] public float VelocidadActual;
            [SerializeField] public float MulVelocidad;
            [SerializeField] public float Delay;
            [SerializeField] public float Duracion;
            [SerializeField] public Ease Ease;
            [SerializeField] public int Loop;
            [SerializeField] public Vector3 EndValue;
            [SerializeField] public LoopType LoopType;
        }
    }
    [System.Serializable]
    public enum TipoSpawn
    {
        Moneda,
        Asteroide1,
        Asteroide2,
        Asteroide3,
        Piedra1,
        Piedra2,
        Piedra3,
        Vacio
    }
}