using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using Unity.Collections;
=======
using Unity.VisualScripting;
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
    public float moveSpeed = 2.5f; //1. 항상 앞에 private가 생략되어있음.
    //2. 앞에가 대문자면 클래스이고 아니면 컴포넌트임, public은 외부에서 수정 가능(공공이란 뜻), 클래스가 생성되면 유니티의 컴포넌트 스크립트 창에서 새로운 데이터 타입이 뜸!
    public Transform playerStartPosition;
    private Rigidbody2D rigid; //5.

    private void Awake() //6.start 보다 빨리
    {
        // 7. 
=======
    public float moveSpeed = 2.5f;
    public Transform playerStartPosition;
    private Rigidbody2D rigid;

    private void Awake()
    {
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
        rigid = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        // 01. transform안의 position을 초기화 해줄 거고 , position이 vector3만 지원해서, 근데 vector3가 없으니까 앞에 new붙혀줌.
        //3. transform.position = new Vector3(-8, -2.6f, 0); // 플레이어 시작 위치, 11번째 줄 추가한 후
        transform.position = playerStartPosition.position; // 유니티 안에서 하이어라키에서 하나 만든 후 스크립트에 추가해야함.(빈 오브젝트로)
=======
        // 플레이어가 시작할 때 내가 지정한 위치로 이동하라.
        transform.position = playerStartPosition.position;
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        // 4. 입력을 받아와야 한다., getkey, getkeydown, getkeyup차이 공부하기
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
        }*/ //8번 후에 지우기, 점프 처럼 코드 바꿀 예정

        //9. 입력 받기(축을 이용해서) 9-1.수평의 입력값
        float moveInput_X = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(moveInput_X * moveSpeed, rigid.velocity.y); // time.deltaTime 안해도 됨. 축을 이용해서 움직이니까 y자리에 처음에 0 넣고 코드 수정하기

        //8.점프-물리힘으로 점프 시킬거임. velcity는 현재 위치에서 계속 어디로 이동하려고 하는 것
        if (Input.GetKey(KeyCode.Space))
        {
            // 9번 코드 작성 후 에러 발생 -> 내려가는 속도가 너무 느려짐(velocity가 0임, 유니티의 rigidbody 컴포넌트 확인, 즉 속도가 0이라는 뜻)
            // 처음에 x좌표에 0 넣었다가 코드 수정하기
            rigid.velocity = new Vector2(rigid.velocity.x, 5); 
        }

        // 입력에 맞는 방향을 설정하는 방법


        // 캐릭터 방향

=======
        // 입력을 받아와야 한다
        float moveInput_X = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(moveInput_X * moveSpeed, rigid.velocity.y);

        if(Input.GetKey(KeyCode.Space))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, 10);
        }

        // 입력에 맞는 방향을 설정하는 법
        // 캐릭터가 방향
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
        // 시간 속력 움직인 거리
    }
}
