using UnityEngine;

/// <summary>
/// 橫向卷軸玩家控制跑酷系統
/// </summary>
public class Player : MonoBehaviour
{
    #region 欄位
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
    #endregion

    // 存取 Transform 第一種方式
    // public Transform traPlayer;

    #region 事件
    private void Update()
    {
        Run();
    }
    #endregion

    #region 方法
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        // 存取 Transform 第一種方式
        // 玩家變形.位移(X，Y，Z)
        // Time.deltaTime 一幀 ㄓㄥˋ 的時間
        // traPlayer.Translate(speed * Time.deltaTime, 0, 0);

        // 存取 Transform 第二種方式
        // 1. 當要控制的 Transform 與此元件同一階層
        // 語法：
        // transform.成員名稱
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    #endregion
}
