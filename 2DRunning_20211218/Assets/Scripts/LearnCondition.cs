using UnityEngine;

/// <summary>
/// 學習條件式(判斷式)
/// 1. if
/// 2. switch
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool hasKey = true;
    public int combo = 0;
    public string weapon;

    // 列舉 enum (下拉式選單)
    // 1. 定義列舉
    public enum Season
    {
        spring, summer, fall, winter
    }
    // 2. 實作列舉
    public Season season;

    private void Start()
    {
        #region if 判斷式
        // if 語法
        // if (布林值) { 程式區塊、演算法、陳述式 }
        // else { 程式區塊、演算法、陳述式 }
        // 快速完成 if + Tab * 2

        // 布林值 等於 true 會執行 {} 內的程式
        // 布林值 等於 false 不執行
        // 實驗：使用 true 與 false 差異
        if (true)
        {
            print("我是判斷式 if");
        }

        // 當布林值 等於 true 會執行 if {} 內容
        // 當布林值 等於 false 會執行 else {} 內容
        // 如果 有鑰匙 開門
        if (hasKey)
        {
            print("開門");
        }
        // 否則 沒有鑰匙 不能開門
        else
        {
            print("不能開門");
        }
        #endregion

        #region switch 判斷式
        // switch 語法
        // switch (判斷的資料) 
        // {
        //      case 值1:
        //          程式內容;
        //          程式內容;
        //          程式內容;
        //          斷開;
        //      case 值2:
        //          程式內容;
        //          程式內容;
        //          程式內容;
        //          斷開;
        //      default:
        //          程式內容;
        //          程式內容;
        //          程式內容;
        //          斷開;
        // }

        // 如果武器 是 刀子 攻擊力 30
        // 如果武器 是 AK47 攻擊力 300
        // 如果武器 是 光劍 攻擊力 100
        switch (weapon)
        {
            case "刀子":
                print("攻擊力 30");
                break;
            case "AK47":
                print("攻擊力 300");
                break;
            case "光劍":
                print("攻擊力 100");
                break;
            default:
                print("這不是武器");
                break;
        }
        #endregion

        // switch + enum
        switch (season)
        {
            case Season.spring:
                print("春天");
                break;
            case Season.summer:
                print("夏天");
                break;
            case Season.fall:
                print("秋天");
                break;
            case Season.winter:
                print("冬天");
                break;
        }
    }

    private void Update()
    {
        // else if 必須寫在 if 下方，數量沒有限制
        // else if (布林值) { 程式區塊、演算法、陳述式 }

        // 如果連擊 等於 10 攻擊力就加 10
        if (combo == 10)
        {
            print("攻擊加 10");
        }
        // 如果連擊 等於 100 攻擊力就加 100
        else if (combo == 100)
        {
            print("攻擊加 100");
        }
        // 如果連擊 等於 500 攻擊力就加 500
        else if (combo == 500)
        {
            print("攻擊加 500");
        }
    }
}
