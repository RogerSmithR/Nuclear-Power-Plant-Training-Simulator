using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputController : MonoBehaviour
{

    public float timer;
    public int interval;
    public float destination;
    float position;
    public Transform ringPos;
    // Start is called before the first frame update
    void Start()
    {
        destination = ringPos.localEulerAngles.y;
        position = destination;
        timer = interval;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 0)
        {
            destination = Random.Range(125, 235);
            timer = interval;
        }
        if (position > destination )
        {
            position -= 10 * Time.deltaTime;
            ringPos.localEulerAngles = new Vector3(0, 180, position);
        }
        if (position < destination)
        {
            position += 10 * Time.deltaTime;
            ringPos.localEulerAngles = new Vector3(0, 180, position);
        }

        timer -= Time.deltaTime;
    }
}
