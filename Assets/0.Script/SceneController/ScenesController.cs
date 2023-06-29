using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    public static ScenesController Instance;    //자신

    private void Start()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);    //삭제(Destory) 안됨
        }
    }

    public void OnSceneChange(string str)
    {
        SceneManager.LoadScene(str);    //Build settig에 있는 Scene 이름에 맞는 Scene 열기
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F9))    //F9를 누르면 Main Scene로 돌아가기
        {
            OnSceneChange("Main");
        }
    }
}
