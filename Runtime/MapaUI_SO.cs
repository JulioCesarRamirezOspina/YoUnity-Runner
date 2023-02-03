using System.Collections.Generic;
using UnityEngine;

namespace Yosoft.Runner
{
    [CreateAssetMenu(fileName = "UI", menuName = "mapa UI", order = 0)]
    public class MapaUI_SO : ScriptableObject
    {
        [SerializeField] public NivelMundo NivelMundoActual;
        [SerializeField] public int MaxPuntaje;
        [SerializeField] public List<Mundo> Mundos;
        
        [System.Serializable]
        public class Mundo
        {
            [SerializeField] public NivelMundo NivelMundo;
            [SerializeField] public string Titulo;
            [SerializeField] public string Descripcion;
            [SerializeField] public int MaxNivel;
            [SerializeField] public int MaxPuntaje;
            [SerializeField] public bool Habilitado= false;
            [SerializeField] public float DuracionRotacion;
            [SerializeField] public List<PosicionTabla> PosicionesTabla;
            [SerializeField] public Escenas CargarEscena;
        }
        [System.Serializable]
        public class PosicionTabla
        {
            [SerializeField] public string Username;
            [SerializeField] public string Ciudad;
            [SerializeField] public int MaxPuntaje;
            [SerializeField] public int Posicion;
            [SerializeField] public int Nivel;
            [SerializeField] public bool EsUsuarioActual;
        }

    }
    [System.Serializable]
    public enum NivelMundo
    {
        RunnerVenus,
        Venus,
        RunerMarte,
        Marte,
        RunnerSaturno,
        Saturno,
        RunnerPluton,
        Pluton
    }
}