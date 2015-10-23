using UnityEngine;
using System.Collections;

public class right_eyebrow : MonoBehaviour
{

    // positions and rotations for left eyebrow
    Vector3 happy_pos = new Vector3(3, 4, -1);
    Vector3 sad_pos = new Vector3(3, 3.5f, -1);
    Vector3 mad_pos = new Vector3(2, 3, -1);

    Vector3 happy_angle = new Vector3(0, 0, 0);
    Vector3 sad_angle = new Vector3(0, 0, -30);
    Vector3 mad_angle = new Vector3(0, 0, 30);

    // Use this for initialization
    void Start()
    {
        // initialize as happy
        gameObject.transform.position = happy_pos;
        gameObject.transform.eulerAngles = happy_angle;
    }

    // Update is called once per frame
    void Update()
    {
        // happy or surprised or chill
        if (Input.GetKeyDown(KeyCode.Alpha0) ||
            Input.GetKeyDown(KeyCode.Alpha3) ||
            Input.GetKeyDown(KeyCode.Alpha5))
        {
            gameObject.transform.position = happy_pos;
            gameObject.transform.eulerAngles = happy_angle;
        }
        // sad
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gameObject.transform.position = sad_pos;
            gameObject.transform.eulerAngles = sad_angle;
        }
        // mad or evil
        else if (Input.GetKeyDown(KeyCode.Alpha2) ||
            Input.GetKeyDown(KeyCode.Alpha4))
        {
            gameObject.transform.position = mad_pos;
            gameObject.transform.eulerAngles = mad_angle;
        }
    }
}
