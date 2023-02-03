using System;
using UnityEngine;
using UnityEngine.Events;

namespace Yosoft.Runner
{
    [CreateAssetMenu(fileName = "talentosSO", menuName = "Yosoft/talentosSO")]
    public class TalentosSO : ScriptableObject
    {
        public int talentos;

        [NonSerialized] public UnityEvent<int> talentosChangeEvent;

        private void OnEnable()
        {
            if (talentosChangeEvent == null) 
                talentosChangeEvent = new UnityEvent<int>();
        }

        public void IncrementarTalentos(int valor)
        {
            talentos += valor;
            talentosChangeEvent.Invoke(talentos);
        }
    }
}