using UnityEngine;
using UnityEngine.UI;           // �ޥ� ���� API

/// <summary>
/// �C���޲z��
/// �����q�B�ɶ��P���ƺ޲z
/// </summary>
public class GameManager : MonoBehaviour
{
    #region ���
    [Header("���")]
    public Image imgHp;
    [Header("�ɶ�")]
    public Text textTime;
    [Header("����")]
    public Text textScore;
    [Header("���a��q"), Range(0, 5000)]
    public float hp = 100;
    [Header("�D�����")]
    public string tagProp = "�D��";
    [Header("��������")]
    public string tagTrap = "����";
    [Header("�Y��|�ɦ媺�D��W��")]
    public string propEatToAddHp = "�ɦ�";
    [Header("�Y��ɦ�D���_��q"), Range(0, 50)]
    public float valueEatToAddHp = 10;
    [Header("�����e��")]
    public CanvasGroup groupFinal;
    [Header("�����e�����D")]
    public Text textFinalTitle;
    [Header("��ܵ����e�����j"), Range(0, 0.5f)]
    public float showFinalInterval = 0.1f;
    [Header("���`�ʵe�Ѽ�")]
    public string parameterDead = "Ĳ�o���`";
    [Header("�L���ϰ�W��")]
    public string namePass = "�L���ϰ�";

    private int score;
    private float hpMax;
    private Animator ani;
    private Player player;
    #endregion

    #region �ƥ�
    private void Start()
    {
        ani = GetComponent<Animator>();
        player = GetComponent<Player>();

        hpMax = hp;             // ��q�̤j�ȹC���}�l�ɫ��w����q��l��
    }

    private void Update()
    {
        UpdateTimeUI();
        UpdateHpUI();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tagProp)
        {
            AddScoreAndUpdateUI(collision.GetComponent<Prop>().score);                              // �[����
            if (collision.name.Contains(propEatToAddHp)) ChangeHpAndUpdateUI(valueEatToAddHp);      // �Y��|�ɦ媺�D��N��_��q
            Destroy(collision.gameObject);                                                          // Destroy (����) �R������
        }

        if (collision.tag == tagTrap)
        {
            ChangeHpAndUpdateUI(-collision.GetComponent<Trap>().damage);
        }

        if (collision.name == namePass)
        {
            Win();
        }
    }
    #endregion

    #region ��k
    /// <summary>
    /// ��ܵ����e��
    /// �C���W�[ 0.2
    /// </summary>
    private void ShowFinal()
    {
        groupFinal.alpha += 0.2f;
    }

    /// <summary>
    /// ��s�ɶ�����
    /// </summary>
    private void UpdateTimeUI()
    {
        // print("��e�����ɶ��G" + Time.timeSinceLevelLoad);
        // ToString() �N����ର�r������
        // () ���i�H�榡�Ʀr��AF�Ʀr�G�p���I��X��A�Ҧp�GF2 �p���I�����
        textTime.text = "�ɶ��G" + Time.timeSinceLevelLoad.ToString("F2");
    }

    /// <summary>
    /// ��s�������
    /// </summary>
    private void UpdateHpUI()
    {
        hp -= Time.deltaTime;
        hp = Mathf.Clamp(hp, 0, hpMax);
        imgHp.fillAmount = hp / hpMax;
        Lose();
    }

    /// <summary>
    /// �[���ƨåB��s����
    /// </summary>
    /// <param name="add">�n�K�[������</param>
    private void AddScoreAndUpdateUI(int add)
    {
        score += add;
        textScore.text = "���ơG" + score;
    }

    // �󴫦W�٧ֱ��� Ctrl + R R
    /// <summary>
    /// �ܧ��q�åB��s����
    /// </summary>
    /// <param name="value">�n�ܧ󪺭�</param>
    private void ChangeHpAndUpdateUI(float value)
    {
        hp += value;
        hp = Mathf.Clamp(hp, 0, hpMax);                     // ��q = �ƾ�.����(��q�A�̤p�ȡA�̤j��) �N��q���b�̤p~�̤j�d��
        imgHp.fillAmount = hp / hpMax;
        Lose();
    }

    /// <summary>
    /// �C������
    /// </summary>
    private void Lose()
    {
        if (hp == 0 && groupFinal.alpha == 0)       // �p�G ��q ���� 0 �åB �����e�� �z���� ���� 0
        {
            textFinalTitle.text = "�D�ԥ���";

            groupFinal.interactable = true;

            ani.SetTrigger(parameterDead);
            player.enabled = false;

            // ���𭫽ƩI�s("��k�W��"�A����ɶ��A���j)
            InvokeRepeating("ShowFinal", 0, showFinalInterval);
        }
    }

    /// <summary>
    /// �ӧQ
    /// </summary>
    private void Win()
    {
        textFinalTitle.text = "�D�Ԧ��\";

        groupFinal.interactable = true;

        player.enabled = false;

        InvokeRepeating("ShowFinal", 0, showFinalInterval);
    }
    #endregion
}
