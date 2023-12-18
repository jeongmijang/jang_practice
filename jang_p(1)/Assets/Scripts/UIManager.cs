using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    //루아는 따로 정의 안하면 글로벌(아무덷서나 접근)이였음 ㅇㅇ?
    //지역 변수(local) 따로 해줬을거임
    [HideInInspector]
    public int testValue = 1;


    public Image bg;

    [SerializeField]
    Color _color;

    bool isChanged;


    Sprite christmas_1; //기본으로 되어 있는 이미지

    [SerializeField]
    Sprite christmas_2; //변경 시킬 것

    [SerializeField]
    TextMeshProUGUI _text;

    int descid = 0;

    void Start()
    {
        christmas_1 = bg.sprite;
        // Debug.Log(testValue);
    }

    public void ChangeColor()
    {
        if (!isChanged)
        {
            bg.sprite = christmas_2;
            _text.text = "eeeeeeeeeeeeeeeeee";
            isChanged = true;
        }
        else
        {

            bg.sprite = christmas_1;
            _text.text = "wwwwwwwwwwwwwwwww";
            isChanged = false;
        }

    }
}

    