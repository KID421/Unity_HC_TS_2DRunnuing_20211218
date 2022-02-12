using UnityEngine;

/// <summary>
/// �ǲߤ�k
/// </summary>
public class LearnMethod : MonoBehaviour
{
    // �� ��k�y�k
    // �׹��� �Ǧ^������� ��k�W�� (�Ѽ�) { �{�����e�B���z���B�t��k }
    // void �L�Ǧ^�G�ϥΦ���k�ɤ��|����ƶǦ^

    private void Start()
    {
        // �I�s�ۭq��k
        // �ۭq��k�W��();
        Test();
        Test();
        ShootFire();
        ShootIce();
        // ���X�ӰѼƴN�n��J�X�Ӥ޼�
        // ���w�]�Ȫ��Ѽƥi�H���ε��޼ơA�H�w�]�Ȭ��D
        // ���h�ӹw�]�ѼƮɥi�ϥΫ��W�覡 �ѼƦW��: ��
        // ���y 170 ������ �U�N
        Shoot("���y", 170, effect: "�U�N");
        Shoot("�B�y", 80);
        Shoot("�q�y", 300, "������");
        int water3 = BuyWater(3);
        print("�R�T���G" + water3);

        float kid = BMI(60, 1.68f);
        print("KID BMI " + kid);
        float test = BMI(70, 1.80f);
        print("test BMI " + test);
    }

    // �ۭq��k�G���|�۰ʰ���A�����I�s
    // �|�۰ʰ��檺�s���ƥ�
    private void Test()
    {
        print("����~");
    }

    // �o�g���y�B�o�g�B�y�B�o�g�q�y
    private void ShootFire()
    {
        print("�o�g���y");
        print("����t�� 100");
        print("�o�g����");
    }

    private void ShootIce()
    {
        print("�o�g�B�y");
        print("����t�� 50");
        print("�o�g����");
    }

    // ���@�ʻP�X�R��
    // �Ѽƻy�k�G�Ѽ�1���� �Ѽ�1�W��, �Ѽ�2���� �Ѽ�2�W��
    // �Ѽƹw�]�ȡG�Ѽ����� �ѼƦW�� = �w�]��
    // �� ���w�]�Ȫ��Ѽƥ�����b�᭱
    private void Shoot(string type, int speed, string sound = "������", string effect = "�z��")
    {
        print("<color=yellow>�o�g" + type + "</color>");
        print("<color=yellow>����t�� " + speed + "</color>");
        print("<color=yellow>�o�g���� " + sound + "</color>");
        print("<color=yellow>�o�g�S�� " + effect + "</color>");
    }

    // �@���Ĥ� 50 ��
    private int BuyWater(int count)
    {
        int price = count * 50;
        return price;
    }

    // BMI �魫 / ���� * ����
    // summary ���O���n���ܭ��n
    /// <summary>
    /// �p�� BMI
    /// </summary>
    /// <param name="weight">�魫</param>
    /// <param name="height">�����A����</param>
    /// <returns>BMI</returns>
    private float BMI(float weight, float height)
    {
        float result = weight / (height * height);
        return result;
    }
}
