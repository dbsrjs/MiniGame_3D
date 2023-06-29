using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    public static ScenesController Instance;    //�ڽ�

    private void Start()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);    //����(Destory) �ȵ�
        }
    }

    public void OnSceneChange(string str)
    {
        SceneManager.LoadScene(str);    //Build settig�� �ִ� Scene �̸��� �´� Scene ����
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F9))    //F9�� ������ Main Scene�� ���ư���
        {
            OnSceneChange("Main");
        }
    }
}
