using UnityEngine;
using System.Collections;

public class black_rectangle_2 : MonoBehaviour
{

    // positions for small mouth
    Vector3 on = new Vector3(0, -3, -4);
    Vector3 off = new Vector3(-30, -30, -30);

    // Use this for initialization
    void Start()
    {
        // initialize as happy
        gameObject.transform.position = off;
    }

    // Update is called once per frame
    void Update()
    {
        // happy or sad or mad or evil
        if (Input.GetKeyDown(KeyCode.Alpha0) ||
            Input.GetKeyDown(KeyCode.Alpha1) ||
            Input.GetKeyDown(KeyCode.Alpha2) ||
            Input.GetKeyDown(KeyCode.Alpha4))
        {
            gameObject.transform.position = off;
        }
        // surprised or chill
        else if (Input.GetKeyDown(KeyCode.Alpha3) ||
            Input.GetKeyDown(KeyCode.Alpha5))
        {
            gameObject.transform.position = on;
        }
    }
}
