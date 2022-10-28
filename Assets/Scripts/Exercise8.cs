using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class Exercise8 : MonoBehaviour
{
    public TMP_InputField username;
    public TextMeshProUGUI message;

    // We avoid blank spaces
    private string regexPattern = "^[A-Za-z0-9_.]+$";

    public void ConfirmUsername()
    {
        // We check if the username is valid
        if (Regex.IsMatch(username.text, regexPattern))
        {
            // The following text is displayed on the screen
            message.text = "Hello " + username.text + ", welcome to this amazing adventure!";
        }
    }
}