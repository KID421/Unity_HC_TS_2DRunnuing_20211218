using UnityEngine;

/// <summary>
/// �ǲ��ݩ� Property
/// </summary>
public class LearnProperty : MonoBehaviour
{
    // �� �ݩʻy�k
    // �׹��� ������� �ݩʦW�� { �s���l }
    // �ֳt���� prop + TAB * 2
    // get ���o
    // set �s��
    public int lv { get; set; }

    public string passwordField;

    // C# �̷s 10 ��
    // Unity �w�] 7 ��
    // ��Ū�ݩ�
    // ��Ū�����Ȫ��y�k�G get => �� ;
    // => �H�ڹF Lambda
    public string passwordProperty { get => "777"; }


    private void Start()
    {
        // �s���ݩ� set
        lv = 100;
        // ���o�ݩ� get
        print("���šG" + lv);

        // �s�����
        passwordField = "1234567";
        print("���o���K�X�G" + passwordField);

        // �s���ݩ�
        // passwordProperty = "1234567";        // ��Ū�ݩʤ�����w��
        print("���o�ݩʱK�X�G" + passwordProperty);
    }
}
