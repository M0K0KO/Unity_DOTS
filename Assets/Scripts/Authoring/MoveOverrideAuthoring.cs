using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public class MoveOverrideAuthoring : MonoBehaviour
{
    public class Baker : Baker<MoveOverrideAuthoring>
    {
        public override void Bake(MoveOverrideAuthoring authoring)
        {
            Entity entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new MoveOverride());
            SetComponentEnabled<MoveOverride>(false);
        }
    }
}


public struct MoveOverride : IComponentData, IEnableableComponent
{
    public float3 targetPosition;
}