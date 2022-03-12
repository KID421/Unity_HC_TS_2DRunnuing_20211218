using UnityEngine;

/// <summary>
/// 道具資訊
/// 分數
/// </summary>
public class Prop : MonoBehaviour
{
    [Header("分數"), Range(0, 1000)]
    public int score;
}
