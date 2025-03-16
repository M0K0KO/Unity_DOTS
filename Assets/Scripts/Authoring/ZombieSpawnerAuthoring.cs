using Unity.Entities;
using UnityEngine;

public class ZombieSpawnerAuthoring : MonoBehaviour
{
    public float timerMax;
    public float randomWalkingdistanceMin;
    public float randomWalkingdistanceMax;
    public class Baker : Baker<ZombieSpawnerAuthoring>
    {
        public override void Bake(ZombieSpawnerAuthoring authoring)
        {
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new ZombieSpawner
            {
                timerMax = authoring.timerMax,
                randomWalkingdistanceMax = authoring.randomWalkingdistanceMax,
                randomWalkingdistanceMin = authoring.randomWalkingdistanceMin,
            });

        }
    }
}

public struct ZombieSpawner : IComponentData
{
    public float timer;
    public float timerMax;
    public float randomWalkingdistanceMin;
    public float randomWalkingdistanceMax;
}
