using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scripts : MonoBehaviour
{
    int descNum = 0;
    public Text descText;
    public Button startBtn;
    public GameObject textBg;

    [SerializeField]
    string[] descTextList =
    {   "�ȶ�.",
        "�����! �� ��������?",
        "���� ���� �غ����ε�, �ֹ��ϽðԿ�?"
        };

      [SerializeField]
    int[] textarray = new int[5];
            //���� ���� 5ĭ�� �迭��
            //�׷��� ���� �� �ȳ־��ָ�?
            //�׷���
            //����Ʈ �� �Ⱦ��Ÿ� 0 or -�� �־� �ذ���.
            // ������ ��
    
    public void ChangeDesc()
    {
        if (descNum == 0)
        {
            textBg.SetActive(true);
            startBtn.gameObject.SetActive(false);
            descText.text = "�ȶ�.";
        }
        else if (descNum == 1)
        {
            descText.text = "�����! �� ��������?"; //����
        }
        else if (descNum == 2)
        {
            descText.text = "���� ���� �غ����ε�, �ֹ��ϽðԿ�?"; //�����
        }
        else if (descNum == 3)
        {
            descText.text = "�� ���� ���ϽŴٰ� �ϼż���..!"; //����
        }
        else if (descNum == 4)
        {
            descText.text = "�ƾ�, �׳� �ϴ� ��������"; //�����
        }
        else if (descNum == 5)
        {
            descText.text = "(���Ծ�. ���̺� �ɴ´�.)"; //only ������
        }
        else if (descNum == 6)
        {
            descText.text = "�̷¼� �����Ծ��"; //����
        }
        else if (descNum == 7)
        {
            descText.text = "(�̷¼��� �д´�) �� �ٹ��̷��� ȭ���Ͻó׿�."; //�����
        }
        else if (descNum == 8)
        {
            descText.text = "�� ��..������ ��ҽ��ϴ�.."; //����
        }
        else if (descNum == 9)
        {
            descText.text = "�ظ��� ������������� �� ���ϼ̳׿�..!"; //�����
        }
        else if (descNum == 10)
        {
            descText.text = "���̿����� ���Ͻð�, �׳�ġŲ������ �Ͻð�, �ֱٱ����� bhc������ ���ϼ̳׿�?";
        }
        else if (descNum == 11)
        {
            descText.text = ""; //
        }
        else if (descNum == 12)
        {
            descText.text = ""; //

        }
        else
        {
            startBtn.gameObject.SetActive(true);
            textBg.SetActive(false);
        }

        if (descNum == 5)
        {
            descNum = 0;
        }
        else
        {
            descText.text = descTextList[descNum]
            // descTextList��� �迭�� descNum��°�� �ش��ϴ�
            //���� descText.text�� �ְڴ�.
            ; descNum++;
        }
    }
}
