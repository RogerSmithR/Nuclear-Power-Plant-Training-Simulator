using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorController : MonoBehaviour
{

    public Transform dialPos;
    public Transform secondDialPos;
    public Transform ringPos;
    public GameObject Green;
    public GameObject Yellow;
    public GameObject Red;
    public int GreenSegments;
    public int YellowSegments;
    public int offset;
    public bool secondDial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(dialPos.localEulerAngles.y > 90 && dialPos.localEulerAngles.y < 270)
        if(secondDial)
        transform.localEulerAngles = new Vector3(0, offset + (dialPos.localEulerAngles.y - secondDialPos.localEulerAngles.y)/2, 0);
        else
        transform.localEulerAngles = new Vector3(0, offset + (dialPos.localEulerAngles.y), 0);

        if (Mathf.Abs(transform.localEulerAngles.y - ringPos.eulerAngles.z) < (18 * GreenSegments))
        {
            Green.SetActive(true);
            Yellow.SetActive(false);
            Red.SetActive(false);
        }
        else if(Mathf.Abs(transform.localEulerAngles.y - ringPos.eulerAngles.z) > (18 * GreenSegments) && Mathf.Abs(transform.localEulerAngles.y - ringPos.eulerAngles.z) < (18 * (GreenSegments + YellowSegments)))
        {
            Green.SetActive(false);
            Yellow.SetActive(true);
            Red.SetActive(false);
        }
        else
        {
            Green.SetActive(false);
            Yellow.SetActive(false);
            Red.SetActive(true);
        }
    }
}
