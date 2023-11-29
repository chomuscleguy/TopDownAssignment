using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public InputField playerNameInput;
    public string playerName;
    public Image[] characterImages;
    private Sprite selectedSprite;
    bool select = false;

    public void OnClick()
    {
        select = true;
    }
    public void SelectImage(Sprite sprtie)
    {
        selectedSprite = sprtie;
        PlayerPrefs.SetString("SelectedCharacterImage", sprtie.name);
    }

    public void StartGame()
    {
        playerName = playerNameInput.text;
        if (select == true)
        {
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
        else
        {
            Debug.Log("ĳ���͸� �������ּ���.");
        }
        
    }
}