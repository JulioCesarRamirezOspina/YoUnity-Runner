using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Yosoft.Runner
{
    public class RunnerManager : MonoBehaviour
    {
        [SerializeField] private NivelRunner nivel;

        private void Start()
        {
            foreach (var spawnable in nivel.Spawnables)
            {
                spawnable.SpawnablePrefab.transform.DOMoveX(10, Random.Range(1f, 100f));
            }
        }
    }
}