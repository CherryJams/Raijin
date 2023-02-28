using TMPro;
using UnityEngine;

public class LevelUI : MonoBehaviour
{
    [SerializeField] private CharacterController2D characterController2D;
    [SerializeField] private TextMeshProUGUI dashCounter;

    private void Update()
    {
        if (dashCounter != null)
        {
            dashCounter.text = characterController2D.GetDashCount().ToString();
        }
    }
}