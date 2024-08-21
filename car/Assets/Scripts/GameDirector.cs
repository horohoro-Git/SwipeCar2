using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flagGo;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //UI �����ϱ�
        float distance = Mathf.Abs((flagGo.transform.position.x) - (car.transform.position.x));
        
        if(distance < 0.8f)
        {
            text.text = "���";
        }
        else
        {

            text.text = $"�Ÿ� : {distance}m";
        }
    }
}
