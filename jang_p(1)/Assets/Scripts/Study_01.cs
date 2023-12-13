using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 이게 주석 한줄이다



/*
 * 이게 주석 여러
 * 줄
 * 이
 * 다.
 */




public class Study_01 : MonoBehaviour
{
    int test;

    void Awake() // 얘가 스타트보다 빨리 1회 실행
    {
        Debug.LogError(test);
    }

    void Start()
    {
        Debug.Log("Start");
    }

    private void OnDestroy()
    {
        Debug.Log("으악! 범인은 바로 너");
    }

    private void Update()
    {
  
    }

    void OnEnable() // 이 스크립트를 가진(컴포넌트로 달린)
                    // 오브젝트가 활성화 될때
    {
        Debug.Log("켜졌다.");
    }

    void OnDisable()
    {
        Debug.Log("꺼졌다.");
    }
}