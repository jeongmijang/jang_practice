using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �̰� �ּ� �����̴�



/*
 * �̰� �ּ� ����
 * ��
 * ��
 * ��.
 */




public class Study_01 : MonoBehaviour
{
    int test;

    void Awake() // �갡 ��ŸƮ���� ���� 1ȸ ����
    {
        Debug.LogError(test);
    }

    void Start()
    {
        Debug.Log("Start");
    }

    private void OnDestroy()
    {
        Debug.Log("����! ������ �ٷ� ��");
    }

    private void Update()
    {
  
    }

    void OnEnable() // �� ��ũ��Ʈ�� ����(������Ʈ�� �޸�)
                    // ������Ʈ�� Ȱ��ȭ �ɶ�
    {
        Debug.Log("������.");
    }

    void OnDisable()
    {
        Debug.Log("������.");
    }
}