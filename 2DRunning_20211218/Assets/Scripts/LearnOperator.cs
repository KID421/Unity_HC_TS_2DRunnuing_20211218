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
        #region �B��l�G�ƾ�
        // �[ +
        print("�[�k�G" + (a + b));     // 13
        // �� -
        print("��k�G" + (a - b));     // 7
        // �� *
        print("���k�G" + (a * b));     // 30
        // �� /
        print("���k�G" + (a / b));     // 3.333
        // �l %
        print("�l�k�G" + (a % b));     // 1

        // �[�@
        // = ���w�Ÿ��G������k��B��A�⵲�G���w������
        e = e + 1;
        print("e �B�⵲�G�G" + e);
        // ���W
        e++;
        print("e �B�⵲�G�G" + e);
        // �A�Ω��k�W e--;

        // �[�Q
        e = e + 10;
        print("e �B�⵲�G�G" + e);   // 13
        // ���w�B��
        e += 10;
        print("e �B�⵲�G�G" + e);   // 23
        // �A�Υ[����l -= *= /= %=
        e -= 10;
        print("e �B�⵲�G�G" + e);   // 13
        #endregion

        #region �B��l�G���
        // ����᪺���G�����L�ȡGtrue�Bfalse
        // �j�� >
        print("�j��G" + (c > d));         // true
        // �p�� <
        print("�p��G" + (c < d));         // false
        // �j�󵥩� >=
        print("�j�󵥩�G" + (c >= d));     // true
        // �p�󵥩� <=
        print("�p�󵥩�G" + (c <= d));     // false
        // ���� ==
        print("����G" + (c == d));         // false
        // ������ !=
        print("������G" + (c != d));       // true
        #endregion

        #region �B��l�G�޿�
        // ����᪺���G�����L�ȡGtrue�Bfalse
        // �޿�B��l�O�w�塞�L�Ȫ��B��
        // �åB && (shift + 7)
        // �u�n�䤤�@�ӥ��L�Ȭ� false ���G�N�O false
        print(true && true);        // true
        print(true && false);       // false
        print(false && true);       // false
        print(false && false);      // false
        // �Ϊ� || (shift + ��)
        // �u�n�䤤�@�ӥ��L�Ȭ� true ���G�N�O true
        print(true || true);        // true
        print(true || false);       // true
        print(false || true);       // true
        print(false || false);      // false
        // �A�� !
        // �N���L���ܬۤ�
        print(!true);               // false
        print(!false);              // true
        #endregion
    }
}
