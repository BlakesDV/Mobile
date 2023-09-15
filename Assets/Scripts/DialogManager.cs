using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    [SerializeField] DialogSystem temp;
    [SerializeField] DialogSystem[] arrayTemp;

    [SerializeField] TextMeshProUGUI txtC;
    [SerializeField] TextMeshProUGUI txtAns1;
    [SerializeField] TextMeshProUGUI txtAns2;

    [SerializeField] GameObject[] arrayButtons;

    // Start is called before the first frame update
    private void Start()
    {
        temp = arrayTemp[0];
        showTxt();
    }

    void showTxt() 
    {
        txtC.text = temp.TxtC;
        txtAns1.text = temp.Ans1;
        txtAns1.text = temp.Ans2;
    }

    public void buttonCtrl(int indice) 
    {
        temp = arrayTemp[temp.arrayRef[indice]];
        if (temp.buttonDel == true) 
        {
            buttonDeactivate();
        }
        showTxt();
    }

    void buttonDeactivate() 
    {
        foreach(var button in arrayButtons) { button.SetActive(false); }
    }
}
