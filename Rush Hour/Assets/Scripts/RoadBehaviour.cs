
using UnityEngine;

public class RoadBehaviour : MonoBehaviour
{
    public GameManager manager;
    public GameObject maincamera;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Character").GetComponent<GameManager>();
        maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if(maincamera.transform.position.z > transform.position.z+10)
        {
            DestroyRoad();
        }
    }

    public void DestroyRoad()
    {
        manager.points += 1;
        Destroy(this.gameObject);
        
    }
}
