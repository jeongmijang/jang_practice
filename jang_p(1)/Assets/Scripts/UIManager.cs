using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    //��ƴ� ���� ���� ���ϸ� �۷ι�(�ƹ��K���� ����)�̿��� ����?
    //���� ����(local) ���� ����������
    [HideInInspector]
    public int testValue = 1;


    public Image bg;

    [SerializeField]
    Color _color;

    bool isChanged;


    Sprite christmas_1; //�⺻���� �Ǿ� �ִ� �̹���

    [SerializeField]
    Sprite christmas_2; //���� ��ų ��

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

    