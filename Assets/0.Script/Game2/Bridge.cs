using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bridge : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        bool isCrack = Random.Range(0, 11) < 5 ? true : false;  // 50% 계산

        for (int i = 0; i < transform.childCount; i++)  //childCount = 부모 오브젝트의 자식 오브젝트의 개수를 반환하는 함수
        {
            transform.GetChild(i).GetComponent<Glass>().isCrack = isCrack;     //위에서 나온 isCrack을 넣는다
            isCrack =  !isCrack;    //그 반대값을 넣는다
        }
    }
}
