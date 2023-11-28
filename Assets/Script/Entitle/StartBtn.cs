using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public InputField playerNameInput;
    public string playerName;

    public void StartGame()
    {
        playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            // �÷��̾��� �г����� ����
            PlayerPrefs.SetString("PlayerName", playerName);

            // ���� ����
            SceneManager.LoadScene("MainScene"); // ���� �� �̸����� �����ؾ� ��
        }
        else
        {
            Debug.Log("�г����� �Է��ϼ���.");
        }
    }
}