using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{

    float indicatorAngle = 90;
    bool started = false;
    public Transform indicatorPos;
    public GameObject script1;
    public GameObject script2;
    public GameObject script3;
    public GameObject script4;
    public GameObject script5;
    public GameObject startable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(started && indicatorAngle < 180)
        {
            indicatorAngle += 8 * Time.deltaTime;
            indicatorPos.localEulerAngles = new Vector3(0, indicatorAngle, 0);
        }
        else if(started && indicatorAngle >= 180)
        {
            script1.SetActive(true);
            script2.SetActive(true);
            script3.SetActive(true);
            script4.SetActive(true);
            script5.SetActive(true);
            started = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (startable.activeSelf)
        {
            started = true;
            indicatorAngle = 90;
            script1.SetActive(false);
            script2.SetActive(false);
            script3.SetActive(false);
            script4.SetActive(false);
            script5.SetActive(false);
            startable.SetActive(false);
        }
    }
}
