using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSetting : MonoBehaviour
{
    public InputField playerNameInput;
    public string playerName;

    public void StartGame()
    {
        playerName = playerNameInput.text;
            if (!string.IsNullOrEmpty(playerName))
            {
                PlayerPrefs.SetString("PlayerName", playerName);
                SceneManager.LoadScene("MainScene");
            }
            else
            {
                Debug.Log("�г����� �Է��ϼ���.");
            }
    }
}