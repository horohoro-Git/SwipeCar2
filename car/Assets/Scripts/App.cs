using UnityEngine;

public class App : MonoBehaviour
{
    float dirX;
    public GameObject car;
    CarController carController;
    Vector3 startPos;
    void Start()
    {   
        carController = car.GetComponent<CarController>();
        carController.callback = MoveStop;
    }

    // Update is called once per frame
    void Update()
    {

        //입력받기
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector3 endPos = Input.mousePosition;
            dirX = endPos.x - startPos.x;
        
            carController.speed = dirX * 0.0001f;
            if (dirX > 0)
            {
                carController.isRight = true;

                carController.PlayCarSound();

            }
            else if(dirX<0)
            {
                carController.isRight = false;

                carController.PlayCarSound();
            }
            carController.moveStart = true;

            
        }
    }

    void MoveStop()
    {
        carController.action();
        //carController.action();
        // Debug.Log("자동차 이동 완료");
    }
}
