using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class openbox : MonoBehaviour
{
    int gold = 0;
    int emerald = 0;
    int ruby = 0;

    int grade01 = 0;
    int grade02 = 0;
    int grade03 = 0;
    int grade04 = 0;
    int grade05 = 0;

    int gg;
    /*
    private void Start()
    {
        OpenBox();
    }
    int value;
    int amount;
    private void OpenBox()
    {
        for (int i = 1; i < 101; i++) // gold=gold+amount
        {
            value = Random.Range(0, 3); // 0
            amount = Random.Range(1, 101); //82 91
            switch (value)
            {
                case 0: // ���
                    gold += amount; // gold = gold+amount; gold+=amount   gold-=amount gold=gold-amount
                    Debug.Log(i + "��° ���� ����Ǿ��� " + amount + "�Դϴ�.");
                    break;
                case 1:// ���޶���
                    emerald += amount;
                    Debug.Log(i + "��° ���� ���޶����Ǿ��� " + amount + "�Դϴ�.");
                    break;
                case 2:// ���
                    ruby += amount;
                    Debug.Log(i + "��° ���� ����Ǿ��� " + amount + "�Դϴ�.");
                    break;
            }
        }
        Debug.Log("�� ������" + gold + "�� ���޶��� ����" + emerald + "�� ������" + ruby);
    }
    */

    private void Start()


    {
        int gradeper;
        int amount01;
        int amount02;
        int amount03;
        int amount04;
        int amount05;
        int counter30;

        for (int i = 1; i < 31; i++)
        {
            gradeper = Random.Range(1,101);
            amount01 = Random.Range(20, 31);
            amount02 = Random.Range(15, 26);
            amount03 = Random.Range(10, 21);
            amount04 = Random.Range(5, 11);
            amount05 = Random.Range(1, 6);

            if (gradeper <= 20)
            {
                Debug.Log(i + "��° ���� ����� 1����Դϴ�. " + "����" + amount01 + "�Դϴ�.");
            }

            else if (gradeper <= 50)
            {
                Debug.Log(i + "��° ���� ����� 2����Դϴ�. " + "����" + amount02 + "�Դϴ�.");
            }

            else if (gradeper <= 90)
            {
                Debug.Log(i + "��° ���� ����� 3����Դϴ�. " + "����" + amount03 + "�Դϴ�.");
            }

            else if (gradeper <= 98)
            {
                Debug.Log(i + "��° ���� ����� 4����Դϴ�. " + "����" + amount04 + "�Դϴ�.");
            }

            else if (gradeper <= 100)
            {
                Debug.Log(i + "��° ���� ����� 5����Դϴ�. " + "����" + amount05 + "�Դϴ�.");
            }
        }
    
        //Debug.Log("1�����" + ��� + "2�����" + ��� + "3�����" + ��� + "4�����" + ��� + "5�����" + ��� + "���Խ��ϴ�.");




    }

}


