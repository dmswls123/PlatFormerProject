using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCoin : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float PopPower = 2.5f;

    private void Start()
    {
<<<<<<< HEAD
        rigid = GetComponent<Rigidbody2D>();  // 컴포넌트를 찾아서 타입이 <Rigidbody2D>인 녀석을 rigid변수에 할당한다.
        rigid.AddForce(Vector2.up * PopPower, ForceMode2D.Impulse);  //vector2.up 방향 힘을 가한다.

        Invoke(nameof(DisableObject), 1.5f); //1.5초 뒤에 DisableObject 함수 실행
        Destroy(gameObject,2f);  //gameObject 2초 뒤에 파괴
=======
        rigid = GetComponent<Rigidbody2D>(); // 컴포넌트를 찾아서 타입이 <Rigidbody2D>인 녀석을 rigid변수에 할당한다.
        rigid.AddForce(Vector2.up * PopPower, ForceMode2D.Impulse); // Vector2.up 방향 힘을 가한다.
        Invoke(nameof(DisableObject),1.5f); // Invoke : 1.5f 뒤에 DisableObject 함수 실행
        Destroy(gameObject, 2f);            // gameObject 파괴한다 2f뒤에
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
    }

    private void DisableObject()
    {
<<<<<<< HEAD
        gameObject.SetActive(false); //오브젝트를 비활성화 해주겠다.
=======
        gameObject.SetActive(false); // 게임 오브젝트를 비활성해라.
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
    }
}
