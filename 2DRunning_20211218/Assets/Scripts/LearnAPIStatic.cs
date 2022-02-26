using UnityEngine;

/// <summary>
/// 學習靜態 API
/// 靜態 Static
/// 非實體物件，不存在遊戲場景內的物件
/// 必學的三種靜態 API 使用方式
/// 1. 取得靜態屬性
/// 2. 存放靜態屬性
/// 3. 使用靜態方法
/// </summary>
public class LearnAPIStatic : MonoBehaviour
{
    private void Start()
    {
        #region 教學區
        // 靜態屬性語法
        // 1. 取得 Get
        // 類別名稱.靜態屬性名稱
        print("圓周率：" + Mathf.PI);
        print("無限大：" + Mathf.Infinity);

        // 2. 存放 Set 
        // 類別名稱.靜態屬性名稱 指定 值；
        // Mathf.PI = 9.87654321f;          // 唯讀屬性不能存放
        Cursor.visible = false;             // 隱藏滑鼠

        // 靜態方法語法
        // 3. 使用
        // 類別名稱.靜態方法名稱(對應的引數)；
        float number777 = Mathf.Abs(-77.7f);
        print("-77.7 取絕對值：" + number777);
        #endregion

        #region 練習區
        print("所有攝影機數量：" + Camera.allCamerasCount);
        print("2D 重力：" + Physics2D.gravity);

        Physics2D.gravity = new Vector2(0, -20);
        print("2D 重力：" + Physics2D.gravity);
        Time.timeScale = 0.5f;

        float number9999 = Mathf.Ceil(9.999f);
        print("9.999 無條件進位：" + number9999);
        Vector3 a = Vector3.one;
        Vector3 b = Vector3.one * 22;
        float dis = Vector3.Distance(a, b);
        print("a 與 b 的距離：" + dis);

        Application.OpenURL("https://unity.com/");
        #endregion
    }

    private void Update()
    {
        print("是否按下任意鍵：<color=red>" + Input.anyKeyDown + "</color>");
        // print("遊戲經過時間：" + Time.time);

        print("玩家是否按下空白鍵：<color=yellow>" + Input.GetKeyDown(KeyCode.Space) + "</color>");
    }
}
