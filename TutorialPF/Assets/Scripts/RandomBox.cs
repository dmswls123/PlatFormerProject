using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBox : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject CoinPrefab; // ���� �������� ����ϰڴ�.
    public bool isActivate = true; // RandomBox�� Ȱ��ȭ �Ǿ� �ִ� �����̴�.
=======
    public GameObject CoinPrefab; // ���� �������� ����ϰڴ�.
    public bool isActivate = true; // RandomBox�� Ȱ��ȭ �Ǿ� �ִ� ���´�.
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
        if (isActivate) // isActivate ������ true�� ���� �Ʒ��ڵ带 �����մϴ�.
        {
            Debug.Log("�浹��");
            isActivate = false;
            Instantiate(CoinPrefab, transform.position, Quaternion.identity); //������������ position�� ���� / instantiate�� ������Ų�ٴ°�

            // �θ���(������Ʈ�̸��� RandomBox����) SpriteRenderer����� sprite ���� time_30���� �����ض�.
=======
        if (isActivate) // isActivate������ true�� ���� �Ʒ��ڵ带 �����մϴ�.
        {
            // ���������� Ŭ�����߽��ϴ�.
            Debug.Log("���� �ڽ��� �����߽��ϴ�.");
            isActivate = false; // isActivate�� false�� �ٲ��
            Instantiate(CoinPrefab, transform.position, Quaternion.identity);

            // �θ���(������Ʈ�̸��� RandomBox����) SpriteRenderer����� sprite ���� tilemap_29�� �����϶�.
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
            _sr.sprite = unActivateBoxSprite;
        }
    }

<<<<<<< HEAD

=======
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("���� �ڽ��� �浹�� �������ϴ�.");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("���� �ڽ��� �浹 ���� ���Դϴ�.");
    }
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
}
