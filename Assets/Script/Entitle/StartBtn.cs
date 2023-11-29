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
                // 플레이어의 닉네임을 저장
                PlayerPrefs.SetString("PlayerName", playerName);

                // 게임 시작
                SceneManager.LoadScene("MainScene"); // 게임 씬 이름으로 변경해야 함
            }
            else
            {
                Debug.Log("닉네임을 입력하세요.");
            }
        }
        else
        {
            Debug.Log("캐릭터를 선택해주세요.");
        }
        
    }
}