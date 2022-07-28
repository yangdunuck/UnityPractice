using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float maxSpeed;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.freezeRotation = true;
    }

    void FixedUpdate()
    {
        //Ű���带 �̿��Ͽ� �̵�
        float h = Input.GetAxisRaw("Horizontal"); 
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed) //������ �������� �ְ�ӵ��� �Ѿ�� �� �ӵ��� �ְ�ӵ��� ����
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        
        else if (rigid.velocity.x < maxSpeed*(-1)) //���� �������� �ְ�ӵ��� �Ѿ�� �� �ӵ��� �ְ�ӵ��� ����
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);


    }
}
