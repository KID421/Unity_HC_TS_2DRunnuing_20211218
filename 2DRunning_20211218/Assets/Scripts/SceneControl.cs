using UnityEngine;
using UnityEngine.SceneManagement;  // �ޥ� �����޲z �R�W�Ŷ��A�i�H�ϥγ��� API

/// <summary>
/// ��������
/// 1. �i�H��������
/// 2. �i�H���}�C��
/// </summary>
public class SceneControl : MonoBehaviour
{
    /// <summary>
    /// ���J����
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene("���d 1");
    }

    // Unity ���s�P�{�����q�覡
    // 1. ���}��k
    // 2. ���s Button ���� On Click �i�H���w����k
    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitGame()
    {
        print("���}�C��");
        Application.Quit();     // ���ε{��.���}() - �����C���AUnity �����|����
    }
}
