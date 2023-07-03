using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4LineColl : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Win")
        {
            Debug.Log("½Â¸®");
        }

        else if (other.gameObject.name == "Lose")
        {
            Debug.Log("ÆÐ¹è");
            Game4GameCont.Instance.SetState = Game4GameCont.State.Stop;
        }
    }
}
