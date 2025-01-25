using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBox : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject CoinPrefab; // 코인 프리팹을 사용하겠다.
    public bool isActivate = true; // RandomBox가 활성화 되어 있는 상태이다.
=======
    public GameObject CoinPrefab; // 코인 프리펩을 사용하겠다.
    public bool isActivate = true; // RandomBox가 활성화 되어 있는 상태다.
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
    SpriteRenderer _sr;
    public Sprite unActivateBoxSprite;

    private void Start()
    {
        _sr = GetComponentInParent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< HEAD
        if (isActivate) // isActivate 변수가 true일 때만 아래코드를 실행합니다.
        {
            Debug.Log("충돌됨");
            isActivate = false;
            Instantiate(CoinPrefab, transform.position, Quaternion.identity); //코인프리팹을 position에 생성 / instantiate가 생성시킨다는것

            // 부모의(오브젝트이름이 RandomBox안의) SpriteRenderer요소의 sprite 값을 time_30으로 변경해라.
=======
        if (isActivate) // isActivate변수가 true일 때만 아래코드를 실행합니다.
        {
            // 스테이지를 클리어했습니다.
            Debug.Log("랜덤 박스와 층돌했습니다.");
            isActivate = false; // isActivate를 false로 바꿔라
            Instantiate(CoinPrefab, transform.position, Quaternion.identity);

            // 부모의(오브젝트이름이 RandomBox안의) SpriteRenderer요소의 sprite 값을 tilemap_29로 변경하라.
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
            _sr.sprite = unActivateBoxSprite;
        }
    }

<<<<<<< HEAD

=======
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("랜덤 박스와 충돌이 끝났습니다.");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("랜덤 박스와 충돌 진행 중입니다.");
    }
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
}
