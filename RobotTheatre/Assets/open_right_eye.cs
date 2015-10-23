using UnityEngine;
using System.Collections;

public class open_right_eye : MonoBehaviour
{
    // on and off positions for the open eyes
    Vector3 off = new Vector3(-30, -30, -30);
    Vector3 on = new Vector3(3, 1, -2);

    // Use this for initialization
    void Start()
    {
        // initialize as happy
        gameObject.transform.position = on;
    }

    // Update is called once per frame
    void Update()
    {
        // happy or sad or mad or surprised or evil
        if (Input.GetKeyDown(KeyCode.Alpha0) ||
            Input.GetKeyDown(KeyCode.Alpha1) ||
            Input.GetKeyDown(KeyCode.Alpha2) ||
            Input.GetKeyDown(KeyCode.Alpha3) ||
            Input.GetKeyDown(KeyCode.Alpha4))
        {
            gameObject.transform.position = on;
        }
        // chill
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            gameObject.transform.position = off;
        }

    }
}
