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
        rigid = GetComponent<Rigidbody2D>();  // ������Ʈ�� ã�Ƽ� Ÿ���� <Rigidbody2D>�� �༮�� rigid������ �Ҵ��Ѵ�.
        rigid.AddForce(Vector2.up * PopPower, ForceMode2D.Impulse);  //vector2.up ���� ���� ���Ѵ�.

        Invoke(nameof(DisableObject), 1.5f); //1.5�� �ڿ� DisableObject �Լ� ����
        Destroy(gameObject,2f);  //gameObject 2�� �ڿ� �ı�
=======
        rigid = GetComponent<Rigidbody2D>(); // ������Ʈ�� ã�Ƽ� Ÿ���� <Rigidbody2D>�� �༮�� rigid������ �Ҵ��Ѵ�.
        rigid.AddForce(Vector2.up * PopPower, ForceMode2D.Impulse); // Vector2.up ���� ���� ���Ѵ�.
        Invoke(nameof(DisableObject),1.5f); // Invoke : 1.5f �ڿ� DisableObject �Լ� ����
        Destroy(gameObject, 2f);            // gameObject �ı��Ѵ� 2f�ڿ�
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
    }

    private void DisableObject()
    {
<<<<<<< HEAD
        gameObject.SetActive(false); //������Ʈ�� ��Ȱ��ȭ ���ְڴ�.
=======
        gameObject.SetActive(false); // ���� ������Ʈ�� ��Ȱ���ض�.
>>>>>>> ff1ec608b6a449eaa79cd454513c429da29f2d2c
    }
}
