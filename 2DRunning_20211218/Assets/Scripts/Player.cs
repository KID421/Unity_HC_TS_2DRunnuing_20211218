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

    [Header("跳躍按鍵")]
    public KeyCode keyJump = KeyCode.Space;

    // 存取 Transform 第一種方式
    // public Transform traPlayer;

    // 屬性面板 ... > Debug 模式可以看到私人資料
    private Rigidbody2D rig;
    [Header("跳躍段數最大值"), Range(0, 5)]
    public int countJumpMax = 2;

    public int countJump;

    [Header("檢查地板位移")]
    public Vector3 v3GroudOffset;
    [Header("檢查地板尺寸")]
    public Vector3 v3GroundSize = Vector3.one;
    [Header("地板的圖層")]
    public LayerMask layerGround;

    // private Animation aniOld;        // 舊版 動畫系統
    // private Animator aniNew;         // 新版 動畫系統

    private Animator ani;
    #endregion

    [Header("滑行按鍵")]
    public KeyCode keySlide = KeyCode.DownArrow;

    private CapsuleCollider2D cc2d;

    #region 事件
    // 繪製圖示事件：在 Unity 內繪製輔助用的圖示，包含：線、方形、圓形等幾何圖形 (執行檔不會顯示)
    private void OnDrawGizmos()
    {
        // 1. 決定圖示顏色
        Gizmos.color = new Color(1, 0, 0.2f, 0.35f);
        // 2. 繪製圖示
        // 圖示.繪製方體(中心點，尺寸)
        Gizmos.DrawCube(transform.position + v3GroudOffset, v3GroundSize);
    }

    private void Start()
    {
        // GetComponent<元件類型>() - <> 泛型，所有類型
        // 取得指定元件
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        cc2d = GetComponent<CapsuleCollider2D>();

        // 跳躍段數 指定為 最大值
        countJump = countJumpMax;
    }

    private void Update()
    {
        Run();
        Jump();
        Slide();
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

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        // 是否按下跳躍 = 輸入.取得按鍵按下(指定按鍵)
        bool inputJump = Input.GetKeyDown(keyJump);
        // print("是否按下跳躍：" + inputJump);

        // 如果 按下跳躍 並且 跳躍段數 大於 零 就 往上跳
        if (inputJump && countJump > 0)
        {
            // print("跳躍");
            // 剛體.添加推力(二維向量)
            rig.AddForce(new Vector2(0, jump));
            // 跳躍之後，跳躍段數減一
            countJump--;
            // 動畫.設定觸發(動畫參數名稱)
            ani.SetTrigger(parameterJump);
        }

        // 2D 碰撞 = 2D 物理.方形覆蓋(中心點，尺寸，角度，圖層)
        Collider2D hit = Physics2D.OverlapBox(transform.position + v3GroudOffset, v3GroundSize, 0, layerGround);

        // print("玩家的重力加速度：" + rig.velocity);

        // 如果 2D 碰撞物件存在 並且 剛體的加速度 Y < 0 (往下掉落)
        if (hit && rig.velocity.y < 0)
        {
            // 跳躍次數 指定 最大跳躍次數
            countJump = countJumpMax;
        }
    }

    /// <summary>
    /// 滑行
    /// </summary>
    private void Slide()
    {
        // 判斷是否按下滑行
        // 更新滑行動畫
        // 更新碰撞器
        if (Input.GetKey(keySlide))
        {
            ani.SetBool(parameterSlide, true);

            // 滑行：0.2, -0.85 | 2, 1.2 h
            cc2d.offset = new Vector2(0.2f, -0.85f);
            cc2d.size = new Vector2(2, 1.2f);
            cc2d.direction = CapsuleDirection2D.Horizontal;
        }
        else
        {
            ani.SetBool(parameterSlide, false);

            // 站立：0.2, -0.2  | 1, 2.5 v
            cc2d.offset = new Vector2(0.2f, -0.2f);
            cc2d.size = new Vector2(1, 2.5f);
            cc2d.direction = CapsuleDirection2D.Vertical;
        }
    }
    #endregion
}
