using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class first : MonoBehaviour
{
    [SerializeField] private TMP_Text txt;
    float time = 0f;
    private void Update()
    {
        time = Time.deltaTime;
    }

    private void OnTriggerExit(Collider other)    //Start
    {
        /*
        time = 0f;
        while (time != 1f)
        {
            txt.text = "Start!";
        }
        Destroy(txt);
        */
    }
}

