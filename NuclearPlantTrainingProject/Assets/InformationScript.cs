using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;
using System.Linq;


public class InformationScript : MonoBehaviour
{
    string s0 = "In nuclear fission, a neutron hits a uranium-235 atom and is absorbed by its nucleus. The new heavier nucleus becomes unstable and splits into smaller nuclei. This gives out a burst of energy (as heat) and two or three extra neutrons. These go on to hit and split other uranium nuclei, resulting in a chain reaction. The reaction keeps going making more and more heat. Nuclear power stations are engineered to control this chain reaction, enabling the amount of heat/energy to be regulated.";
    string s1 = "Control rods - They control the chain reaction by absorbing neutrons, so there are less of them bouncing around splitting uranium-235 nuclei. They go in and out of the reactor core; the further they lowered in, the more neutrons they absorb and the fewer nuclei can be split. By controlling the fission reaction they control the amount of heat produced in the reactor core. Note: Powerful electromagnets hold the control rods above the reactor core, so that in the event of a power cut the control rods would automatically fall into it and stop the nuclear reaction within 4 seconds.";
    string s2 = "Coolant - Water that is pumped to the reactor core and then around the nuclear reactor. It has two jobs to do: 1. It slows down the neutrons in the reactor core, which makes the fission reaction more effective. 2. It absorbs the heat produced in the reactor core and carries it to a different part of the reactor. Note: the coolant water also contains boric acid. Boron absorbs neutrons so the coolant, along with the control rods, also helps to control the nuclear reaction.";
    string s3 = "Coolant pumps - The coolant pumps move the coolant around the 'primary circuit' which runs between the reactor core and the steam generators. The coolant enters the pressure vessel at 290 degree celsius. When the reactor starts up, the pumps heat the coolant to the correct temperature before operation begins. \n\n" +
        "Pressuriser - The coolant becomes very horeaching up to around 325 degree celsius. But we do not want it to boil and turn to steam, like water would normally do when it reaches 100 degree celsium. The pressuriser keeps the coolant at a very high pressure, forcing it to stay liquid. That is why it is called a pressurised water reactor.";
    string s4 = "Steps\n\n"+"1. Switch on the coolant pumps. Once the coolant has reached 290 degree celsius go to step 2.\n\n"+ "2. Lift the control rods slightly to start generating heat. Just 10% is enough. If the reactor gets too hot, it will automatically shut down so try to keep dials in the green zone.\n\n";
    string s5 = "3. Increase the steam output from the steam generators to turn the turbines and produce electricity. The power demand will change at different times of the day. Match the output to the power demand by adjusting the control rods and steam output.";

    public GameObject infoCanvasGameObject;
    public GameObject displayLabelGameObject;
    public GameObject nextbuttonGameObject;
    public GameObject previousbuttonGameObject;

    //This is to enable or disable the ray interactor on the right hand controller when the menu is opened or closed -Jackson
    public GameObject interactRay;
    int infoCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        displayLabelGameObject.GetComponent<Text>().text = s0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void displayingNextInfo()
    {
        infoCounter++;
        Debug.Log("Here");
        if (infoCounter == 1)
        {
            nextbuttonGameObject.SetActive(true);
            previousbuttonGameObject.SetActive(true);
            displayLabelGameObject.GetComponent<Text>().text = s1;
        }
        if (infoCounter == 2)
        {
            displayLabelGameObject.GetComponent<Text>().text = s2;
        }
        if (infoCounter == 3)
        {
            displayLabelGameObject.GetComponent<Text>().text = s3;
        }
        if (infoCounter == 4)
        {
            displayLabelGameObject.GetComponent<Text>().text = s4;
            nextbuttonGameObject.SetActive(true);
        }
        if (infoCounter == 5)
        {
            previousbuttonGameObject.SetActive(true);
            displayLabelGameObject.GetComponent<Text>().text = s5;
            nextbuttonGameObject.SetActive(false);
        }
    }

    public void displayingPreviousInfo()
    {
        if (infoCounter != 0)
            infoCounter--;

        if (infoCounter == 0)
        {
            previousbuttonGameObject.SetActive(false);
            displayLabelGameObject.GetComponent<Text>().text = s0;
        }

        if (infoCounter == 1)
        {
            previousbuttonGameObject.SetActive(true);
            nextbuttonGameObject.SetActive(true);
            displayLabelGameObject.GetComponent<Text>().text = s1;
        }
        if (infoCounter == 2)
        {
            displayLabelGameObject.GetComponent<Text>().text = s2;
        }
        if (infoCounter == 3)
        {
            displayLabelGameObject.GetComponent<Text>().text = s3;
        }
        if (infoCounter == 4)
        {
            nextbuttonGameObject.SetActive(true);
            displayLabelGameObject.GetComponent<Text>().text = s4;
        }
        if (infoCounter == 5)
        {
            nextbuttonGameObject.SetActive(false);
            displayLabelGameObject.GetComponent<Text>().text = s5;
        }
    }

    public void closeCanvas()
    {
        infoCanvasGameObject.SetActive(false);
        interactRay.SetActive(false);
    }

    public void ooenCanvas()
    {
        infoCanvasGameObject.SetActive(true);
        interactRay.SetActive(true);
    }

    public void whenBookSelected()
    {
        infoCanvasGameObject.SetActive(true);
        interactRay.SetActive(true);
    }

    public void whenBookDropped()
    {
        infoCanvasGameObject.SetActive(false);
        interactRay.SetActive(false);
    }
}
