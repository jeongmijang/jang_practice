using UnityEngine;

public class CarController : MonoBehaviour
{

    float speed = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //왼쪽 마우스를 누르면
        {
            this.speed = 0.2f;    //처음 속도를 설정
        }
        

        transform.Translate(speed, 0, 0); //이동을 시키는 함수다. 
        speed *= 0.98f;                  // 감속 (사실은 물리가 적용되어있다)
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
    // 스와이프의 길이를 구한다
    if (Input.GetMouseButtonDown(0))
    {
        // 마우스를 클릭한 좌표
        startPos = Input.mousePosition;
        Debug.Log(startPos);
    }
    else if (Input.GetMouseButtonUp(0))
    {
        // 마우스를 떼었을 때 좌표
        Vector2 endPos = Input.mousePosition;
        float swipeLength = endPos.x - startPos.x;

        // 스와이프 길이를 처음 속도로 변환한다
        speed = swipeLength / 500.0f; //500은 적당한 보정값임
        // intput.mousePosition으로 얻어지는 벡터값은 해상도의 영향을 받음
    }

   
    transform.Translate(speed, 0, 0);  // 이동
    speed *= 0.98f;                    // 감속
}
}
