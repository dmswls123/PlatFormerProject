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
    public float moveSpeed = 2.5f; //1. �׻� �տ� private�� �����Ǿ�����.
    //2. �տ��� �빮�ڸ� Ŭ�����̰� �ƴϸ� ������Ʈ��, public�� �ܺο��� ���� ����(�����̶� ��), Ŭ������ �����Ǹ� ����Ƽ�� ������Ʈ ��ũ��Ʈ â���� ���ο� ������ Ÿ���� ��!
    public Transform playerStartPosition;
    private Rigidbody2D rigid; //5.

    private void Awake() //6.start ���� ����
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
        // 01. transform���� position�� �ʱ�ȭ ���� �Ű� , position�� vector3�� �����ؼ�, �ٵ� vector3�� �����ϱ� �տ� new������.
        //3. transform.position = new Vector3(-8, -2.6f, 0); // �÷��̾� ���� ��ġ, 11��° �� �߰��� ��
        transform.position = playerStartPosition.position; // ����Ƽ �ȿ��� ���̾��Ű���� �ϳ� ���� �� ��ũ��Ʈ�� �߰��ؾ���.(�� ������Ʈ��)
=======
        // �÷��̾ ������ �� ���� ������ ��ġ�� �̵��϶�.
        transform.position = playerStartPosition.position;
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        // 4. �Է��� �޾ƿ;� �Ѵ�., getkey, getkeydown, getkeyup���� �����ϱ�
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
        }*/ //8�� �Ŀ� �����, ���� ó�� �ڵ� �ٲ� ����

        //9. �Է� �ޱ�(���� �̿��ؼ�) 9-1.������ �Է°�
        float moveInput_X = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(moveInput_X * moveSpeed, rigid.velocity.y); // time.deltaTime ���ص� ��. ���� �̿��ؼ� �����̴ϱ� y�ڸ��� ó���� 0 �ְ� �ڵ� �����ϱ�

        //8.����-���������� ���� ��ų����. velcity�� ���� ��ġ���� ��� ���� �̵��Ϸ��� �ϴ� ��
        if (Input.GetKey(KeyCode.Space))
        {
            // 9�� �ڵ� �ۼ� �� ���� �߻� -> �������� �ӵ��� �ʹ� ������(velocity�� 0��, ����Ƽ�� rigidbody ������Ʈ Ȯ��, �� �ӵ��� 0�̶�� ��)
            // ó���� x��ǥ�� 0 �־��ٰ� �ڵ� �����ϱ�
            rigid.velocity = new Vector2(rigid.velocity.x, 5); 
        }

        // �Է¿� �´� ������ �����ϴ� ���


        // ĳ���� ����

=======
        // �Է��� �޾ƿ;� �Ѵ�
        float moveInput_X = Input.GetAxisRaw("Horizontal");
        rigid.velocity = new Vector2(moveInput_X * moveSpeed, rigid.velocity.y);

        if(Input.GetKey(KeyCode.Space))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, 10);
        }

        // �Է¿� �´� ������ �����ϴ� ��
        // ĳ���Ͱ� ����
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
        // �ð� �ӷ� ������ �Ÿ�
    }
}
