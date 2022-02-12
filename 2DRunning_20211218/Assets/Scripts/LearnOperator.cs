using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;
    public int c = 100;
    public int d = 9;
    public int e = 1;

    private void Start()
    {
        #region 運算子：數學
        // 加 +
        print("加法：" + (a + b));     // 13
        // 減 -
        print("減法：" + (a - b));     // 7
        // 乘 *
        print("乘法：" + (a * b));     // 30
        // 除 /
        print("除法：" + (a / b));     // 3.333
        // 餘 %
        print("餘法：" + (a % b));     // 1

        // 加一
        // = 指定符號：先執行右邊運算再把結果指定給左邊
        e = e + 1;
        print("e 運算結果：" + e);
        // 遞增
        e++;
        print("e 運算結果：" + e);
        // 適用於減法上 e--;

        // 加十
        e = e + 10;
        print("e 運算結果：" + e);   // 13
        // 指定運算
        e += 10;
        print("e 運算結果：" + e);   // 23
        // 適用加減乘除餘 -= *= /= %=
        e -= 10;
        print("e 運算結果：" + e);   // 13
        #endregion

        #region 運算子：比較
        // 比較後的結果為布林值：true、false
        // 大於 >
        print("大於：" + (c > d));         // true
        // 小於 <
        print("小於：" + (c < d));         // false
        // 大於等於 >=
        print("大於等於：" + (c >= d));     // true
        // 小於等於 <=
        print("小於等於：" + (c <= d));     // false
        // 等於 ==
        print("等於：" + (c == d));         // false
        // 不等於 !=
        print("不等於：" + (c != d));       // true
        #endregion

        #region 運算子：邏輯
        // 比較後的結果為布林值：true、false
        // 邏輯運算子是針對布林值的運算
        // 並且 && (shift + 7)
        // 只要其中一個布林值為 false 結果就是 false
        print(true && true);        // true
        print(true && false);       // false
        print(false && true);       // false
        print(false && false);      // false
        // 或者 || (shift + 鎮)
        // 只要其中一個布林值為 true 結果就是 true
        print(true || true);        // true
        print(true || false);       // true
        print(false || true);       // true
        print(false || false);      // false
        // 顛倒 !
        // 將布林值變相反
        print(!true);               // false
        print(!false);              // true
        #endregion
    }
}
