using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Finish : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;   //Timer
    private DateTime startTime;

    [SerializeField] private GameObject txt;    //End

    private void Awake()
    {
        txt.SetActive(false);

        startTime = DateTime.Now;   //���� �ð��� ���� ��
        InvokeRepeating("UpdateClockTime", 0f, 0.01f);     //������ �Լ��� ������ �ð� �������� �ݺ� ȣ��(ȣ���� �Լ��� �̸�, ù ��° ȣ������� ���� �ð�, ȣ�� ����)
    }

    private void UpdateClockTime()
    {
        timeText.text = string.Format("{0:mm\\:ss}", PlayTime());   //"�ð�:��"�� PlayTime�� �ð��� ���
    }

    private TimeSpan PlayTime()
    {
        return DateTime.Now - startTime;    //�ð� ���
    }

    private void OnTriggerEnter(Collider other)    //EndLine�� �浹�ϱ� ������ ��
    {
        txt.SetActive(true);
        CancelInvoke("UpdateClockTime");     //�Լ��� ȣ��� �ݺ� ȣ���� ����ϴ� ���( ����� �Լ��� �̸�)
    }
}

