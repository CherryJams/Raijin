using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class TimeRetriever : MonoBehaviour
{
    private String time;

    private void OnEnable()
    {
        time = PlayerPrefs.GetString("Record", "No time");
    }

    private void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = time;
    }
}