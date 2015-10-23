using UnityEngine;
using System.Collections;

public class black_rectangle : MonoBehaviour
{

    // positions for black circle
    Vector3 happy = new Vector3(0, -2.11f, -3);
    Vector3 sad = new Vector3(0, -5, -3);
    Vector3 off = new Vector3(-30, -30, -30);

    // Use this for initialization
    void Start()
    {
        // initialize as happy
        gameObject.transform.position = happy;
    }

    // Update is called once per frame
    void Update()
    {
        // happy or evil
        if (Input.GetKeyDown(KeyCode.Alpha0) ||
            Input.GetKeyDown(KeyCode.Alpha4))
        {
            gameObject.transform.position = happy;
        }
        // sad or mad 
        else if (Input.GetKeyDown(KeyCode.Alpha1) ||
            Input.GetKeyDown(KeyCode.Alpha2))
        {
            gameObject.transform.position = sad;
        }
        // surprised or chill
        else if (Input.GetKeyDown(KeyCode.Alpha1) ||
            Input.GetKeyDown(KeyCode.Alpha2))
        {
            gameObject.transform.position = off;
        }
    }
}