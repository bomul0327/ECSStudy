using UnityEngine;
using Unity.Entities;


/// <summary>
/// 속도 데이터들
/// </summary>
public struct LinearVelocityComponent : IComponentData
{
    /// <summary>
    /// 초당 일정하게 움직이는 속도
    /// </summary>
    public Vector2 BaseSpeed;

    /// <summary>
    /// 초당 적용되는 가속도
    /// </summary>
    public Vector2 Accel;
}
