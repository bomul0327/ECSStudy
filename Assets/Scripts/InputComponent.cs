using UnityEngine;
using Unity.Entities;

/// <summary>
/// 플레이어가 받을 인풋들
/// </summary>
public struct InputComponent : IComponentData
{
    /// <summary>
    /// X축 입력값
    /// </summary>
    public float Horizontal;

    /// <summary>
    /// Y축 입력값
    /// </summary>
    public float Vertical;
}
