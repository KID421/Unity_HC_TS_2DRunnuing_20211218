using UnityEngine;

/// <summary>
/// 橫向卷軸玩家控制跑酷系統
/// </summary>
public class Player : MonoBehaviour
{
    // 跑步速度、跳躍高度、是否滑行、是否死亡
    // 動畫參數跳躍、滑行與死亡
    // 欄位屬性 Attribute
    // Header 標題
    // Range 範圍：僅限於數值型態資料，float、int
    // Tooltip 提示
    [Header("跑步速度"), Range(0, 500)]
    public float speed = 1.5f;
    [Header("跳躍高度"), Range(0, 5000)]
    public int jump = 500;
    [Tooltip("儲存角色是否在滑行")]
    public bool isSlide;
    [Tooltip("儲存角色是否死亡")]
    public bool isDead;

    public string parameterJump = "觸發跳躍";
    public string parameterSlide = "開關滑行";
    public string parameterDead = "觸發死亡";
}
