using UnityEngine;
using UnityEngine.UI;           // 引用 介面 API

/// <summary>
/// 遊戲管理器
/// 角色血量、時間與分數管理
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("血條")]
    public Image imgHp;
    [Header("時間")]
    public Text textTime;
    [Header("分數")]
    public Text textScore;
    [Header("玩家血量"), Range(0, 5000)]
    public float hp = 100;
    [Header("道具標籤")]
    public string tagProp = "道具";
    [Header("陷阱標籤")]
    public string tagTrap = "陷阱";

    private int score;
    private float hpMax;

    private void Start()
    {
        hpMax = hp;             // 血量最大值遊戲開始時指定成血量初始值
    }

    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();
    }

    /// <summary>
    /// 更新時間介面
    /// </summary>
    private void UpdateTimeUI()
    {
        // print("當前場景時間：" + Time.timeSinceLevelLoad);
        // ToString() 將資料轉為字串類型
        // () 內可以格式化字串，F數字：小數點後幾位，例如：F2 小數點後兩位數
        textTime.text = "時間：" + Time.timeSinceLevelLoad.ToString("F2");
    }

    /// <summary>
    /// 更新血條介面
    /// </summary>
    private void UpdateHpUI()
    {
        hp -= Time.deltaTime;
        imgHp.fillAmount = hp / hpMax;
    }

    /// <summary>
    /// 加分數並且更新介面
    /// </summary>
    /// <param name="add">要添加的分數</param>
    private void AddScoreAndUpdateUI(int add)
    {
        score += add;
        textScore.text = "分數：" + score;
    }

    /// <summary>
    /// 造成傷害並且更新介面
    /// </summary>
    /// <param name="damage">造成的傷害</param>
    private void TakeDamageAndUpdateUI(float damage)
    {
        hp -= damage;
        imgHp.fillAmount = hp / hpMax;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print("玩家碰到的物件：" + collision.name);

        if (collision.tag == tagProp)
        {
            AddScoreAndUpdateUI(collision.GetComponent<Prop>().score);
            Destroy(collision.gameObject);                                  // Destroy (物件) 刪除物件
        }

        if (collision.tag == tagTrap)
        {
            TakeDamageAndUpdateUI(collision.GetComponent<Trap>().damage);
        }
    }
}
