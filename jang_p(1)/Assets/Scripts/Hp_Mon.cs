using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hp_Mon : MonoBehaviour
{
    // HP 깍이는 량 - 20씩 깎이게 설정
    private GameObject Mon_hp_Slider;
    private float mon_hp_speedPRE = 100;
    float atk = 20;

    public Slider Mon_hp_bar;

    public void Atk()
    {
        mon_hp_speedPRE = mon_hp_speedPRE - atk;
        Mon_hp_bar.value = mon_hp_speedPRE;
        Debug.Log(mon_hp_speedPRE);
    }


    //hp가 깎이면, 슬라이더의 모습


    //public void Return_mon_bar()
    //{
    //    Mon_hp_bar.value = Mon_hp_bar.value - 20;
    //}

    //몬스터 사망시 (hp = 0)

    public GameObject Mon;
    public GameObject Cha;
    public void Mon_died()
    {
        if (Mon_hp_bar.value <= 0) //몬스터 hp바 값이 0보다 같거나 작을때
        {
            Mon.SetActive(false);// 몬스터 이미지 안보이기
            mon_hp_speedPRE = 100;
            Cha.transform.position = new Vector3(10, 10, 10);
            Cha.transform
        }
        else
        {
            Mon.SetActive(true); // 몬스터 이미지 보이기
        }




    }



}


