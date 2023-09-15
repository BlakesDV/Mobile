using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Prueba : MonoBehaviour
{
    public Text displayText;

    public UnityEvent initTxt;
    public void DisplayText()
    {
        displayText.text = "P";
    }
    
    void Start()
    {
        //crear eventos
        initTxt = new UnityEvent();
        initTxt.AddListener(buttonStart);
    }
    
    public void buttonStart()
    {
        Debug.Log("Iniciando");
    }
    public void buttonCredits()
    {
        Debug.Log("By Blakes");
    }

    void Update()
    {
        
    }
     public void StartButton()
    {
        initTxt.Invoke();
    }
}
