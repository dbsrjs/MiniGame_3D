using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game4LineColl : MonoBehaviour
{
    [SerializeField] private GameObject obj;  //End
    [SerializeField] private TMP_Text txt;
    private void Start()
    {
        obj.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Win")
        {
            Game4GameCont.Instance.SetState = Game4GameCont.State.Stop;
            obj.SetActive(true);
            txt.text = "Win";

        }

        else if (other.gameObject.name == "Lose")
        {
            Game4GameCont.Instance.SetState = Game4GameCont.State.Stop;
            obj.SetActive(true);
            txt.text = "Lose";
        }
    }
}
