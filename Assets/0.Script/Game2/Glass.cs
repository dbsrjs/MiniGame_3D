using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
    [HideInInspector]
    public bool isCrack = false;

    private void Update()
    {
        if(GetComponent<MeshRenderer>() && isCrack)    //MeshRenderer�̶�� ������Ʈ�� ���� �ְ� isCrack(false)�� ��
        {
            GetComponent<MeshRenderer>().materials[0].color = Color.red;    //materials�� ���� red�� ����
        }
    }
    
    private void OnCollisionEnter(Collision collision)     //�� �ݶ��̴��� ���� ������Ʈ���� �浹�� �����ϸ� �ڵ����� ȣ��
    {
        if(isCrack)   //isCrack(false)�� ��
        {
            Destroy(gameObject);   //�ڽ�(false�� ������Ʈ)�� ����
        }
    }
}
