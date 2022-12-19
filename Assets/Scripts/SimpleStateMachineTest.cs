using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleStateMachineTest : MonoBehaviour
{

    public Button b1;
    public Button b2;
    public Button b3;
    public Button b4;
    public Button b5;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        b1.onClick.AddListener(TaskOnClickb1);
        b2.onClick.AddListener(TaskOnClickb2);
        b3.onClick.AddListener(TaskOnClickb3);
        b4.onClick.AddListener(TaskOnClickb4);
        b5.onClick.AddListener(TaskOnClickb5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClickb1(){
        Debug.Log("armlift geklickt");
        animator.SetFloat("Wiederholung",5.0f);
        //animator.SetTrigger("Animation_armlift");
        animator.Play("Animation_armlift",0,0.0f);
    }
    void TaskOnClickb2(){
        Debug.Log("neckstretch geklickt");
        //animator.SetTrigger("Animation_neckstretch");
        animator.Play("Animation_neckstretch",0,0.0f);
    }
    void TaskOnClickb3(){
        Debug.Log("backstretch geklickt");
        //animator.SetTrigger("Animation_backstretch");
        animator.Play("Animation_backstretch",0,0.0f);
    }
    void TaskOnClickb4(){
        Debug.Log("snowangel geklickt");
        animator.SetFloat("Wiederholung",5.0f);
        //animator.SetTrigger("Animation_snowangel");
        animator.Play("Animation_snowangel",0,0.0f);
    }
    void TaskOnClickb5(){
        Debug.Log("sideneckstretch geklickt");
        //animator.SetTrigger("Animation_sideneckstretch");
        animator.Play("Animation_sideneckstretch",0,0.0f);
    }
}
