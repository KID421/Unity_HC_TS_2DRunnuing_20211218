using UnityEngine;

/// <summary>
/// 學習方法
/// </summary>
public class LearnMethod : MonoBehaviour
{
    // ※ 方法語法
    // 修飾詞 傳回資料類型 方法名稱 (參數) { 程式內容、陳述式、演算法 }
    // void 無傳回：使用此方法時不會有資料傳回

    private void Start()
    {
        // 呼叫自訂方法
        // 自訂方法名稱();
        Test();
        Test();
        ShootFire();
        ShootIce();
        // 有幾個參數就要輸入幾個引數
        // 有預設值的參數可以不用給引數，以預設值為主
        // 有多個預設參數時可使用指名方式 參數名稱: 值
        // 火球 170 咻咻咻 燃燒
        Shoot("火球", 170, effect: "燃燒");
        Shoot("冰球", 80);
        Shoot("電球", 300, "滋滋滋");
        int water3 = BuyWater(3);
        print("買三罐：" + water3);

        float kid = BMI(60, 1.68f);
        print("KID BMI " + kid);
        float test = BMI(70, 1.80f);
        print("test BMI " + test);
    }

    // 自訂方法：不會自動執行，必須呼叫
    // 會自動執行的叫做事件
    private void Test()
    {
        print("測試~");
    }

    // 發射火球、發射冰球、發射電球
    private void ShootFire()
    {
        print("發射火球");
        print("飛行速度 100");
        print("發射音效");
    }

    private void ShootIce()
    {
        print("發射冰球");
        print("飛行速度 50");
        print("發射音效");
    }

    // 維護性與擴充性
    // 參數語法：參數1類型 參數1名稱, 參數2類型 參數2名稱
    // 參數預設值：參數類型 參數名稱 = 預設值
    // ※ 有預設值的參數必須放在後面
    private void Shoot(string type, int speed, string sound = "咻咻咻", string effect = "爆炸")
    {
        print("<color=yellow>發射" + type + "</color>");
        print("<color=yellow>飛行速度 " + speed + "</color>");
        print("<color=yellow>發射音效 " + sound + "</color>");
        print("<color=yellow>發射特效 " + effect + "</color>");
    }

    // 一罐藥水 50 塊
    private int BuyWater(int count)
    {
        int price = count * 50;
        return price;
    }

    // BMI 體重 / 身高 * 身高
    // summary 不是必要但很重要
    /// <summary>
    /// 計算 BMI
    /// </summary>
    /// <param name="weight">體重</param>
    /// <param name="height">身高，公尺</param>
    /// <returns>BMI</returns>
    private float BMI(float weight, float height)
    {
        float result = weight / (height * height);
        return result;
    }
}
