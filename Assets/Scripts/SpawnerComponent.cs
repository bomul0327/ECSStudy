using UnityEngine;
using Unity.Entities;

/// <summary>
/// 오브젝트 스포너가 필요한 데이터들
/// </summary>
public struct SpawnerComponent : IComponentData
{
    /// <summary>
    /// 최초 활성화 된 뒤에 몇 초 동안 딜레이
    /// </summary>
    public float StartDelay;

    /// <summary>
    /// 스폰 시키는 주기
    /// </summary>
    public float SpawnRate;

    /// <summary>
    /// 오브젝트에 적용하는 첫 직선 운동 속도 값
    /// </summary>
    public LinearVelocityComponent StartLinearVelocity;

    /// <summary>
    /// 오브젝트에 적용하는 첫 회전 운동 속도 값
    /// </summary>
    public LinearVelocityComponent StartAngularVelocity;
    
    // TODO: 더 다양한 데이터들 추가
}
