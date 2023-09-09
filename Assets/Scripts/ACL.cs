using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ACL : MonoBehaviour
{
    [SerializeField] private TMP_InputField ageInputField;
    [SerializeField] private TMP_InputField sexInputField;
    [SerializeField] private TMP_InputField locationInputField;
    [SerializeField] private TextMeshProUGUI resultText;


    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            DisplayResult();
        }
    }

    private void DisplayResult()
    {
        resultText.text = "Result: " + ageInputField.text + " " + sexInputField.text + " " +locationInputField.text;
    }

}
