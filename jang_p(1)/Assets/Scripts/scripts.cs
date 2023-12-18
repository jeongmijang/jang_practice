using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scripts : MonoBehaviour
{
    int descNum = 0;
    public Text descText;
    public Button startBtn;
    public GameObject textBg;

    [SerializeField]
    string[] descTextList =
    {   "똑똑.",
        "사장님! 문 열었나요?",
        "아직 오픈 준비중인데, 주문하시게요?"
        };

      [SerializeField]
    int[] textarray = new int[5];
            //위에 놈은 5칸의 배열임
            //그래서 따로 값 안넣어주면?
            //그래서
            //퀘스트 때 안쓸거면 0 or -로 넣어 준거임.
            // 업으면 준
    
    public void ChangeDesc()
    {
        if (descNum == 0)
        {
            textBg.SetActive(true);
            startBtn.gameObject.SetActive(false);
            descText.text = "똑똑.";
        }
        else if (descNum == 1)
        {
            descText.text = "사장님! 문 열었나요?"; //꼬꼬
        }
        else if (descNum == 2)
        {
            descText.text = "아직 오픈 준비중인데, 주문하시게요?"; //사장님
        }
        else if (descNum == 3)
        {
            descText.text = "아 직원 구하신다고 하셔서요..!"; //꼬꼬
        }
        else if (descNum == 4)
        {
            descText.text = "아아, 네네 일단 들어오세요"; //사장님
        }
        else if (descNum == 5)
        {
            descText.text = "(가게안. 테이블에 앉는다.)"; //only 지문만
        }
        else if (descNum == 6)
        {
            descText.text = "이력서 가져왔어요"; //꼬꼬
        }
        else if (descNum == 7)
        {
            descText.text = "(이력서를 읽는다) 아 근무이력이 화려하시네요."; //사장님
        }
        else if (descNum == 8)
        {
            descText.text = "아 네..열심히 살았습니다.."; //꼬꼬
        }
        else if (descNum == 9)
        {
            descText.text = "왠만한 프랜차이즈에서는 다 일하셨네요..!"; //사장님
        }
        else if (descNum == 10)
        {
            descText.text = "교촌에서도 일하시고, 네네치킨에서도 하시고, 최근까지는 bhc에서도 일하셨네요?";
        }
        else if (descNum == 11)
        {
            descText.text = ""; //
        }
        else if (descNum == 12)
        {
            descText.text = ""; //

        }
        else
        {
            startBtn.gameObject.SetActive(true);
            textBg.SetActive(false);
        }

        if (descNum == 5)
        {
            descNum = 0;
        }
        else
        {
            descText.text = descTextList[descNum]
            // descTextList라는 배열의 descNum번째에 해당하는
            //값을 descText.text에 넣겠다.
            ; descNum++;
        }
    }
}
