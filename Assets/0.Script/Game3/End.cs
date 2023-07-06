using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class End : MonoBehaviour
{
    [SerializeField] private Car left;
    [SerializeField] private Car right;

    [SerializeField] private TMP_Text txt;
    [SerializeField] private GameObject end;

    private void Start()
    {
        end.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        end.SetActive(true);

        left.enabled = false;
        right.enabled = false;

        txt.text = "Game over";
    }
}
