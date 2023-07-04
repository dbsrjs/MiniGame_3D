using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game4GameCont : MonoBehaviour
{
    public static Game4GameCont Instance;

    public enum State
    {
        Play,
        Stop,
    }

    
    [SerializeField] private Transform line;
    [SerializeField] private TMP_Text countTxt;

    private float power = 1.2f;     //���� �ӵ�
    private State stace = State.Stop;
    private int count = 3;

    public State SetState
    {
        set
        {
            stace = value;
        }
    }
    private void Start()
    {
        Instance = this;
        InvokeRepeating("Count", 1, 1);    //CountDown
    }
    // Update is called once per frame
    void Update()
    {
        if (stace == State.Stop)
        {
            return;
        }

        line.Translate(Vector3.right * Time.deltaTime * power);    //Line�� �ڵ����� ���������� �̵�

        if (Input.GetKeyDown(KeyCode.Space)) //Speace�� ������ �� x���� -0.4 �ϱ�
        {

            Vector3 pos = line.localPosition;
            pos.x -= 0.4f;
            line.localPosition = pos;
        }
    }

    void Count()
    {
        countTxt.text = count.ToString();
        count--;

        if (count < 0)
        {
            countTxt.text = string.Empty;
            stace = State.Play;
            CancelInvoke("Count");
        }
    }
}
