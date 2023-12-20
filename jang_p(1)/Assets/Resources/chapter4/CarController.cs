using UnityEngine;

public class CarController : MonoBehaviour
{

    float speed = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //���� ���콺�� ������
        {
            this.speed = 0.2f;    //ó�� �ӵ��� ����
        }
        

        transform.Translate(speed, 0, 0); //�̵��� ��Ű�� �Լ���. 
        speed *= 0.98f;                  // ���� (����� ������ ����Ǿ��ִ�)
    }
}


float speed = 0;
Vector2 startPos;

void Start()
{
    Application.targetFrameRate = 60;
}

void Update()
{
    // ���������� ���̸� ���Ѵ�
    if (Input.GetMouseButtonDown(0))
    {
        // ���콺�� Ŭ���� ��ǥ
        startPos = Input.mousePosition;
        Debug.Log(startPos);
    }
    else if (Input.GetMouseButtonUp(0))
    {
        // ���콺�� ������ �� ��ǥ
        Vector2 endPos = Input.mousePosition;
        float swipeLength = endPos.x - startPos.x;

        // �������� ���̸� ó�� �ӵ��� ��ȯ�Ѵ�
        speed = swipeLength / 500.0f; //500�� ������ ��������
        // intput.mousePosition���� ������� ���Ͱ��� �ػ��� ������ ����
    }

   
    transform.Translate(speed, 0, 0);  // �̵�
    speed *= 0.98f;                    // ����
}
}
