using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSystem : MonoBehaviour
{
    [SerializeField] private GameObject sceneCont;    //ScenesController
    // Start is called before the first frame update
    void Start()
    {
        if (ScenesController.Instance == null)
        {
            Instantiate(sceneCont).name = "[ Scene Controller ]";   //ScenesController 생성
        }
    }

    public void OnGameChange(string gameName)
    {
        ScenesController.Instance.OnSceneChange(gameName);  //gameName에 맞는 Scene으로 이동
    }
}
