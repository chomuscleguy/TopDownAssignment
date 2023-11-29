using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    bool IsSelect = false;
    public Image selectImage;
    public Sprite[] characterImage;

    public void SelectImage(int imageIndex)
    {
        IsSelect = true;
        selectImage.sprite = characterImage[imageIndex];
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
