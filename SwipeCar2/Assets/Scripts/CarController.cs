using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //화면을 스와이프하면 자동차가 이동

    //스와이프 액션
    //1화면을 누른다
    //2 드래그 한다
    //3 화면에서 손을 뗀다

    //스와이프 액션을 통해서 방향
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
