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

        startTime = DateTime.Now;   //현재 시간을 갖고 옴
        InvokeRepeating("UpdateClockTime", 0f, 0.01f);     //지정된 함수를 일정한 시간 간격으로 반복 호출(호출할 함수의 이름, 첫 번째 호출까지의 지연 시간, 호출 간격)
    }

    private void UpdateClockTime()
    {
        timeText.text = string.Format("{0:mm\\:ss}", PlayTime());   //"시간:초"로 PlayTime의 시간을 출력
    }

    private TimeSpan PlayTime()
    {
        return DateTime.Now - startTime;    //시간 계산
    }

    private void OnTriggerEnter(Collider other)    //EndLine와 충돌하기 시작할 때
    {
        txt.SetActive(true);
        CancelInvoke("UpdateClockTime");     //함수로 호출된 반복 호출을 취소하는 기능( 취소할 함수의 이름)
    }
}

