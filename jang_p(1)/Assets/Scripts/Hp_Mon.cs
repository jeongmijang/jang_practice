using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hp_Mon : MonoBehaviour
{
    // HP ���̴� �� - 20�� ���̰� ����
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


    //hp�� ���̸�, �����̴��� ���


    //public void Return_mon_bar()
    //{
    //    Mon_hp_bar.value = Mon_hp_bar.value - 20;
    //}

    //���� ����� (hp = 0)

    public GameObject Mon;
    public GameObject Cha;
    public void Mon_died()
    {
        if (Mon_hp_bar.value <= 0) //���� hp�� ���� 0���� ���ų� ������
        {
            Mon.SetActive(false);// ���� �̹��� �Ⱥ��̱�
            mon_hp_speedPRE = 100;
            Cha.transform.position = new Vector3(10, 10, 10);
            Cha.transform
        }
        else
        {
            Mon.SetActive(true); // ���� �̹��� ���̱�
        }




    }



}


