using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bridge : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        bool isCrack = Random.Range(0, 11) < 5 ? true : false;  // 50% ���

        for (int i = 0; i < transform.childCount; i++)  //childCount = �θ� ������Ʈ�� �ڽ� ������Ʈ�� ������ ��ȯ�ϴ� �Լ�
        {
            transform.GetChild(i).GetComponent<Glass>().isCrack = isCrack;     //������ ���� isCrack�� �ִ´�
            isCrack =  !isCrack;    //�� �ݴ밪�� �ִ´�
        }
    }
}
