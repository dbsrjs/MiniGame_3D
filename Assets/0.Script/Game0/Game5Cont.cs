using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game5Cont : MonoBehaviour
{
    [SerializeField] private Player p;
    [SerializeField] private TMP_Text txt;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Transform boss;

    string[] strs = { "��", "��", "ȭ", "��", "��", "��", "��", "��", "��", "��" };

    string curStr;
    int strIndex = 0;
    float curTimer;
    float strDelayTime = 0f;
    int waitTimer = 10; //���� ��� �ð�

    bool isStart = false;
    bool isStop = false;

    Vector3 pStopPos;
    // Start is called before the first frame update
    void Start()
    {
        WaitTime();
        InvokeRepeating("WaitTime", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStart)
            return;

        curTimer += Time.deltaTime;
        if (curTimer >= strDelayTime)
        {
            curTimer = 0;
            curStr = strs[strIndex];
            txt.text = curStr;
            strIndex++;

            if(strIndex >= strs.Length)
            {
                strIndex = 0;
                strDelayTime = Random.Range(1f, 3f);
                isStop = true;
                pStopPos = p.transform.position;
                boss.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0));
            }
            else
            {
                strDelayTime = Random.Range(.05f, .5f);
                isStop = false;
                boss.rotation = Quaternion.Euler(Vector3.zero);
            }
        }

        if(isStop)
        {
            if(pStopPos != p.transform.position)
            {
                isStop = false;
                PlayerKill();
            }
        }

        if(p.isFinish)
        {
            isStart = false;
            txt.text = $"���";
        }
    }

    void WaitTime()    //�ð� ��� ī��Ʈ�ٿ�
    {
        waitTimer--;
        txt.text = $"���� ���: {waitTimer}�� ��...";

        if(waitTimer <= 0)
        {
            isStart = true;
            CancelInvoke();

            if(!p.isStart)
            {
                PlayerKill();
            }
        }
    }

    void PlayerKill()   //�÷��̾ �׾�����
    {
        txt.text = "����";
        p.Dead();
        audioSource.Play();
    }
}
