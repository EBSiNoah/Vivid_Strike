using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int Power;
    public int Speed;
    public int CounterPoint;
    public int Stemina;
    public int Reach;
    public int Mana;
        
    public GameObject Preparation;//기본 동작

    public Vector3 Position;//위치

    public float Timer = 0;

    public GameObject Player;

    public Attack PunchAction;

    // Start is called before the first frame update
    void Start()
    {
        Preparation = Instantiate(Resources.Load("Normal")) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.U))
        {
            Preparation.SetActive(false);
            //Destroy(preparation);

            PunchAction.Punch(Timer);          
        }        
    }
    /*
    public virtual void Punch(float Frame_time)//float Frame_time
    {

    }
    */
    public void Preparation_Back()
    {
        //Debug.Log("Work?");

        //Preparation.SetActive(true);        
    }
}
