using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4LineColl : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Win")
        {
            Debug.Log("�¸�");
        }

        else if (other.gameObject.name == "Lose")
        {
            Debug.Log("�й�");
            Game4GameCont.Instance.SetState = Game4GameCont.State.Stop;
        }
    }
}
