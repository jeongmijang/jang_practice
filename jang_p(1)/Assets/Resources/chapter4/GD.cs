using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject car; // "car"라는 "GameObject"를 담을 변수
    GameObject flag;
    GameObject distance;

    void Start()
    {
        //GameObject.Find("하이어라키에 "켜져있는"
        //오브젝트들 중 이름으로 찾는 방법
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        flagposX = flag.transform.position.x;
    }
    float flagposX;
    void Update()
    {
        // start()에서 flag.car를 찾았음.
        // gameObject.transform.position =
        // transform.position = 그 오브젝트의 위치 정보(좌표값0을 받아옴
         float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
    }
}
