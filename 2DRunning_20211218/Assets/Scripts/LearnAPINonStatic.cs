using UnityEngine;

/// <summary>
/// 學習非靜態 API
/// 非靜態 Non-Static
/// 實體物件，存在遊戲場景內的物件
/// 必學的三種非靜態 API 使用方式
/// 1. 取得非靜態屬性
/// 2. 存放非靜態屬性
/// 3. 使用非靜態方法
/// </summary>
public class LearnAPINonStatic : MonoBehaviour
{
    public Transform traCar1;
    public GameObject goCar;
    public Camera cam;
    public SpriteRenderer spr;
    public Transform banana;
    public Rigidbody2D apple;

    private void Start()
    {
        #region 教學區
        // 靜態與非靜態最大的差異
        // ※ 1. 非靜態需要有實體物件存在
        // ※ 2. 定義一個欄位
        // ※ 3. 儲存該實體物件
        // 實體物件：
        // 1. 遊戲物件 Game Object：在 Hierarchy 內的白色線框圖示物件
        // 2. 預製物 Prefab：在 Hierarchy 內的藍色箱型圖示物件
        // 3. 元件 Component：1 與 2 屬性面板上可折疊的

        // 非靜態屬性語法
        // 1. 取得 Get
        // 欄位名稱.非靜態屬性名稱
        print("汽車的座標：" + traCar1.position);
        // 2. 存放 Set 
        // 欄位名稱.非靜態屬性名稱 指定 值；
        traCar1.position = new Vector3(-5, 3, 1);

        // 靜態方法語法
        // 3. 使用
        // 欄位名稱.非靜態屬性名稱(對應的引數)；
        goCar.SetActive(false);
        #endregion

        #region 練習區
        print("取得攝影機深度：" + cam.depth);
        print("取得奇異果的圖片顏色：" + spr.color);

        cam.backgroundColor = Random.ColorHSV();
        spr.flipY = true;
        #endregion
    }

    private void Update()
    {
        banana.Rotate(0, 0, 10);
        apple.AddForce(new Vector2(0, 10));
    }
}
