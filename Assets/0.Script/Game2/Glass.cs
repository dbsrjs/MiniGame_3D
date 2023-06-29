using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
    [HideInInspector]
    public bool isCrack = false;

    private void Update()
    {
        if(GetComponent<MeshRenderer>() && isCrack)    //MeshRenderer이라는 컴포넌트를 갖고 있고 isCrack(false)일 떄
        {
            GetComponent<MeshRenderer>().materials[0].color = Color.red;    //materials의 색을 red로 지정
        }
    }
    
    private void OnCollisionEnter(Collision collision)     //두 콜라이더를 가진 오브젝트끼리 충돌을 감지하면 자동으로 호출
    {
        if(isCrack)   //isCrack(false)일 때
        {
            Destroy(gameObject);   //자신(false인 오브젝트)을 삭제
        }
    }
}
