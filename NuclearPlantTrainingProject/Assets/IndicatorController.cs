using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorController : MonoBehaviour
{

    public Transform dialPos;
    public Transform ringPos;
    public GameObject Green;
    public GameObject Yellow;
    public GameObject Red;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialPos.eulerAngles.y > 90 && dialPos.eulerAngles.y < 270)
        transform.localEulerAngles = new Vector3(0, (dialPos.eulerAngles.y), 0);

        if(Mathf.Abs(dialPos.eulerAngles.y - ringPos.eulerAngles.z) < 54)
        {
            Green.SetActive(true);
            Yellow.SetActive(false);
            Red.SetActive(false);
        }
        else if(Mathf.Abs(dialPos.eulerAngles.y - ringPos.eulerAngles.z) > 54 && Mathf.Abs(dialPos.eulerAngles.y - ringPos.eulerAngles.z) < 72)
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
