using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //ȭ���� ���������ϸ� �ڵ����� �̵�

    //�������� �׼�
    //1ȭ���� ������
    //2 �巡�� �Ѵ�
    //3 ȭ�鿡�� ���� ����

    //�������� �׼��� ���ؼ� ����
    float carSpeed;
    bool carStop;
    bool carMove;
    float positionX;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            carMove = true;
            positionX = Input.mousePosition.x;
        }
        if(carMove)
        {
            float currentX = Input.mousePosition.x;

            carSpeed = currentX - positionX;
            positionX = currentX;


            transform.Translate(carSpeed * 0.01f, 0, 0);

        }

        if (Input.GetMouseButtonUp(0))
        {
            carMove = false;
        }
    }
}
