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
                case 0: // 골드
                    gold += amount; // gold = gold+amount; gold+=amount   gold-=amount gold=gold-amount
                    Debug.Log(i + "번째 뽑은 골드의양은 " + amount + "입니다.");
                    break;
                case 1:// 에메랄드
                    emerald += amount;
                    Debug.Log(i + "번째 뽑은 에메랄드의양은 " + amount + "입니다.");
                    break;
                case 2:// 루비
                    ruby += amount;
                    Debug.Log(i + "번째 뽑은 루비의양은 " + amount + "입니다.");
                    break;
            }
        }
        Debug.Log("총 골드수는" + gold + "총 에메랄드 수는" + emerald + "총 루비수는" + ruby);
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
                Debug.Log(i + "번째 뽑은 등급은 1등급입니다. " + "골드는" + amount01 + "입니다.");
            }

            else if (gradeper <= 50)
            {
                Debug.Log(i + "번째 뽑은 등급은 2등급입니다. " + "골드는" + amount02 + "입니다.");
            }

            else if (gradeper <= 90)
            {
                Debug.Log(i + "번째 뽑은 등급은 3등급입니다. " + "골드는" + amount03 + "입니다.");
            }

            else if (gradeper <= 98)
            {
                Debug.Log(i + "번째 뽑은 등급은 4등급입니다. " + "골드는" + amount04 + "입니다.");
            }

            else if (gradeper <= 100)
            {
                Debug.Log(i + "번째 뽑은 등급은 5등급입니다. " + "골드는" + amount05 + "입니다.");
            }
        }
    
        //Debug.Log("1등급은" + 몇번 + "2등급은" + 몇번 + "3등급은" + 몇번 + "4등급은" + 몇번 + "5등급은" + 몇번 + "나왔습니다.");




    }

}


