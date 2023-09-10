using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum Levels
{
    Easy,
    Medium,
    Hard
}

public class LevelSelecter : MonoBehaviour
{
    [SerializeField] private Levels levels;
    [SerializeField] private TextMeshProUGUI displayText;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            displayText.text = "You Selected "+ levels.ToString() + ".";
        }
    }

    public void Easy()
    {
        levels = Levels.Easy;
    }

    public void Medium()
    {
        levels = Levels.Medium;
    }

    public void Hard()
    {
        levels = Levels.Hard;
    }
}
