using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Action;//동작

    public float Action_frame = 0;

    public float Start_frame = 0;

    public Character Player;

    // Start is called before the first frame update
    void Start()
    {
        //Action_frame = gameObject.transform.parent.GetComponent<Character>().Timer;

        //StartCoroutine("update");
    }

    // Update is called once per frame
    void Update()
    {/*
        if (Timer - Action_frame >= 9 * Time.deltaTime || Timer - Action_frame <= 11 * Time.deltaTime)
        {
            Preparation_Back();
        }*/

        Action_frame += Time.deltaTime;

        Player.Preparation_Back();
    }

    public void Punch(float Frame_time)
    {
        //Destroy(action);

        Start_frame = Frame_time;

        Debug.Log("punch!");

        Action = Instantiate(Resources.Load("Normal_Punch")) as GameObject;

        Destroy(Action, 10 * Time.deltaTime);

        //preparation = Instantiate(Resources.Load("Normal")) as GameObject;        

        //Preparation_Back();
    }
    /*
    public override void Preparation_Back()
    {
        base.Preparation_Back();

        if(Start_frame != 0 && (Action_frame - Start_frame >= 9*Time.deltaTime && Action_frame - Start_frame <= 11*Time.deltaTime))
        {
            Debug.Log("Work?");

            Preparation.SetActive(true);
        }
    }*/
}