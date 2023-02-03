using System;
using UnityEngine;
using Yosoft.Core;

namespace Yosoft.Runner
{
    public class SpawnerRunner : MonoBehaviour
    {
        [SerializeField] public RunnerUI_SO.Spawn DatosSpawn;
        [SerializeField] public Movimiento movimiento;
        [SerializeField] public TalentosSO TalentosSO;

        public Action<SpawnerRunner> OnPickup;
        // Start is called before the first frame update
        void Awake()
        {
            if (movimiento != null && DatosSpawn != null)
            {
                movimiento.delay = DatosSpawn.Delay;
                movimiento.eslocal = false;
                movimiento.duration = DatosSpawn.Duracion;
                movimiento.easy = DatosSpawn.Ease;
                movimiento.loop = DatosSpawn.Loop;
                movimiento.endValue = DatosSpawn.EndValue;
                movimiento.loopType = DatosSpawn.LoopType;

                //  Tipo; 
                //  Prefab;
                //  Posicion;
                //  Rotacion;
                // MinVelocidad;
                // MaxVelocidad;
                // VelocidadActual;
                // MulVelocidad;
            }
        }

        // Update is called once per frame
        
        private void OnTriggerEnter2D(Collider2D collision){

            if(collision.gameObject.CompareTag("Finish")){
                
                Destroy(this.gameObject);
            }

            if(collision.gameObject.CompareTag("Nave")){
                TalentosSO.IncrementarTalentos(5);
                OnPickup?.Invoke(this);
                gameObject.SetActive(false);
                Destroy(this.gameObject);
            }
        }
    }
}
