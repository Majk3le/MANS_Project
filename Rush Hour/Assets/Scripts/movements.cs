using System.Collections;

using UnityEngine;

public class movements : MonoBehaviour
{   
    public UIManager UIManager;
    public GameObject Car;
    
    float acceleration;
    float speed;
    int position;
    float Timer;
    // Start is called before the first frame update
    void Start()
    {
       

        acceleration = 0.5f;
        speed = 10f;
        position = 0;
    }

    // Update is called once per frame
    void Update()
    {
        speed += acceleration * Time.deltaTime;

        Car.transform.position += new Vector3(0,0,speed * Time.deltaTime);

        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))&& position>-1)
        {
            Car.transform.position += new Vector3(-3.2f, 0, speed * Time.deltaTime);
            position -= 1;
        }
        if ((Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.D)) && position < 1)
        {
            Car.transform.position += new Vector3(3.2f, 0, speed* Time.deltaTime);
            position += 1;
        }
        

    }
}
