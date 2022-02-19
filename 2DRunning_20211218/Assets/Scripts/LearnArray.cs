using UnityEngine;

/// <summary>
/// 學習陣列
/// </summary>
public class LearnArray : MonoBehaviour
{
    // 陣列作用
    // 儲存相同類型的多筆資料

    // 使用欄位儲存多筆資料
    public int atk1 = 10;
    public int atk2 = 20;
    public int atk3 = 30;

    // 陣列語法
    // 資料類型[]
    public int[] atks;

    // 陣列初始值
    // 1. 指定陣列資料數量不指定值
    public float[] speeds = new float[5];
    // 2. 指定陣列資料值
    public string[] props = { "紅水", "藍水", "黃水" };
    public Vector3[] positions = { new Vector3(0, 1, 2), new Vector3(2, 2, 2) };
    public bool[] complete = { true, false, false, false };

    private void Start()
    {
        // 存取陣列資料
        // 1. 存放陣列資料
        // 陣列名稱[編號] = 值；
        // 將陣列第一筆資料改為 70
        atks[0] = 70;
        // 2. 使用陣列會遇到的錯誤：超出陣列範圍
        // IndexOutOfRange - 編號不存在
        // atks[3] = 99;

        // 3. 取得陣列資料
        // 陣列名稱[編號]
        print("第二筆道具資料：" + props[1]);
        print("第二筆座標資料：" + positions[1]);

        // 4. 取得陣列數量 Length
        print("布林值陣列的數量：" + complete.Length);
    }
}
