using UnityEngine;

/// <summary>
/// ��V���b���a����]�Ũt��
/// </summary>
public class Player : MonoBehaviour
{
    #region ���
    // �]�B�t�סB���D���סB�O�_�Ʀ�B�O�_���`
    // �ʵe�ѼƸ��D�B�Ʀ�P���`
    // ����ݩ� Attribute
    // Header ���D
    // Range �d��G�ȭ���ƭȫ��A��ơAfloat�Bint
    // Tooltip ����
    [Header("�]�B�t��"), Range(0, 500)]
    public float speed = 1.5f;
    [Header("���D����"), Range(0, 5000)]
    public int jump = 500;
    [Tooltip("�x�s����O�_�b�Ʀ�")]
    public bool isSlide;
    [Tooltip("�x�s����O�_���`")]
    public bool isDead;

    public string parameterJump = "Ĳ�o���D";
    public string parameterSlide = "�}���Ʀ�";
    public string parameterDead = "Ĳ�o���`";
    #endregion

    // �s�� Transform �Ĥ@�ؤ覡
    // public Transform traPlayer;

    #region �ƥ�
    private void Update()
    {
        Run();
    }
    #endregion

    #region ��k
    /// <summary>
    /// �]�B
    /// </summary>
    private void Run()
    {
        // �s�� Transform �Ĥ@�ؤ覡
        // ���a�ܧ�.�첾(X�AY�AZ)
        // Time.deltaTime �@�V ������ ���ɶ�
        // traPlayer.Translate(speed * Time.deltaTime, 0, 0);

        // �s�� Transform �ĤG�ؤ覡
        // 1. ��n��� Transform �P������P�@���h
        // �y�k�G
        // transform.�����W��
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
    #endregion
}
