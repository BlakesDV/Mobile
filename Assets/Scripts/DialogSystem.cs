using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogSystem : MonoBehaviour
{
    [SerializeField, TextArea(5,8)] private string[] dialogLines;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;

    public Image C1;
    public Image C2;
    public Text N1, N2, Conv;

    public float txtSpeed = 1;
    public int posTxt;
    public Dialog[] dialogs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if () 
        //{
        //    StartDialogue();
        //}
    }

    private void StartDialogue() 
    {

    }


    public struct Dialog
    {
        public string C1;
        public string C2;
    }
}
