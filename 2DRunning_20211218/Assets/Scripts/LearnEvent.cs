using UnityEngine;

public class LearnEvent : MonoBehaviour
{
    // 開始事件
    // 開始遊戲時執行此事件一次
    // 處理初始資料
    private void Start()
    {
        // 輸出(輸出資料); print();
        print("哈囉，沃德 :D");
    }

    // 更新事件
    // 開始遊戲後每秒約執行六十次 60FPS
    // 處理持續執行的行為
    private void Update()
    {
        print("我在 Update 事件內~");
    }
}
