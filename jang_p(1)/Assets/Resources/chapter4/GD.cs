using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject car; // "car"��� "GameObject"�� ���� ����
    GameObject flag;
    GameObject distance;

    void Start()
    {
        //GameObject.Find("���̾��Ű�� "�����ִ�"
        //������Ʈ�� �� �̸����� ã�� ���
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        flagposX = flag.transform.position.x;
    }
    float flagposX;
    void Update()
    {
        // start()���� flag.car�� ã����.
        // gameObject.transform.position =
        // transform.position = �� ������Ʈ�� ��ġ ����(��ǥ��0�� �޾ƿ�
         float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m";
    }
}
