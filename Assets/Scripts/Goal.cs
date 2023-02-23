using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] private GameObject timer;
private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetString("Record",timer.GetComponent<Timer>().GetTime());
            SceneManager.LoadScene(2);
        }
    }
}
