using System.Collections;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using Yosoft.Core;

namespace Yosoft.Runner
{
    public class GeneradorRunner : MonoBehaviour
    {
        [SerializeField] public RunnerUI_SO DatosRunner;
        void Start()
        {
            if (DatosRunner != null)
            {

                StartCoroutine(GenerarSpawn());
            }
        }

        private IEnumerator  GenerarSpawn()
        {
            var so = DatosRunner;
            foreach (var iteracion in so.Iteraciones)
            {
                foreach (var spawn in iteracion.Spawners.Where(spawn => spawn.Prefab != null))
                {
                    var spawnerRunner = spawn.Prefab.GetComponent<SpawnerRunner>();
                    //TODO: Cargar SO Movimiento directamente
                    //TODO: Quitar esta parte de inicializacion por defecto
                    spawn.Duracion = 5;
                    spawn.Ease = Ease.Linear;
                    spawn.Loop = 1;
                    
                    
                    if (spawnerRunner != null) spawnerRunner.DatosSpawn = spawn;
                    var posicion = new Vector3(17,spawn.Posicion.y,0);
                    Instantiate(spawn.Prefab, posicion, Quaternion.identity);
                }

                yield  return Helpers.GetWait(so.Frecuencia);
            }
        }
        
    }
}
