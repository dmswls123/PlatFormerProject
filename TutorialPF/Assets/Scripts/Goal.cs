using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< HEAD
        // 스테이지 클리어
        Debug.Log("스테이지를 클리어 했습니다.");
=======
        // 스테이지를 클리어했습니다.
        Debug.Log("스테이지를 클리어했습니다.");
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
<<<<<<< HEAD
        Debug.Log("충돌지점에서 빠져나갔습니다.");
=======
        Debug.Log("충돌 지점에서 벗어났습니다.");
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
<<<<<<< HEAD
        Debug.Log("충돌 진행중 입니다.");
    }
}
=======
        Debug.Log("충돌 진행 중입니다.");
    }
}
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
