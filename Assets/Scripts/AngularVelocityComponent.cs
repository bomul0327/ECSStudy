using UnityEngine;
using Unity.Entities;

/// <summary>
/// 각속도 데이터들
/// </summary>
public struct AngularVelocityComponent : IComponentData
{
    /// <summary>
    /// 축이 되는 지점
    /// </summary>
    public Vector2 AxisPoint;

    /// <summary>
    /// 초당 일정하게 돌아가는 속력
    /// </summary>
    public float BaseSpeed;

    /// <summary>
    /// 초당 적용되는 가속
    /// </summary>
    public float Accel;
}
