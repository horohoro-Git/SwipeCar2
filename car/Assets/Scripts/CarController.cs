using UnityEngine;

public class CarController : MonoBehaviour
{
    //화면 밖의 최대최소 값
    const float maxDistance= 7.5f, minDistance = -7.5f;
    public delegate void Callback();
    public Callback callback;
    public System.Action action;

    float dirX;
    public float speed;
    Vector3 startPos;
    public bool moveStart;

    public bool isRight;

    private void Start()
    {
        //대리자 람다식 인스턴스화
        action = () => { Debug.Log("자동차 이동 완료"); moveStart = false; };
    }
    // Update is called once per frame
    void Update()
    {
        //차량 이동시키기
        if (moveStart)
        {
            if (speed <= 0.001f && isRight == true)
            {
                // action();
                callback();
            }
            else if(speed >= -0.001f && isRight == false)
            {
                //action();
                callback();
            }
            transform.Translate(speed, 0, 0);

            float v = Mathf.Clamp(transform.position.x, -7.5f, 7.5f);
            transform.position = new Vector3(v, transform.position.y, transform.position.z);
          /*  if (speed > 0 && !(transform.position.x >= maxDistance))
            {
                transform.Translate(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), 0, 0);
            }
            else if (speed < 0 && !(transform.position.x <= minDistance))
            {
                transform.Translate(speed, 0, 0);
            }*/
           
            speed *= 0.99f;
            
        }
        
    }

    public void PlayCarSound()
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
        Debug.Log("차소리");
    }
}
