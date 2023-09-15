using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(menuName ="TxtObj")]
public class DialogSystem : MonoBehaviour
{
    [TextArea(3, 15)]
    public string TxtC;
    [Space(20)]
    public string Ans1;
    [Space(20)]
    public string Ans2;
    [Space(20)]
    public int[] arrayRef = new int[2];
    [Space(20)]
    public bool buttonDel;

    [SerializeField, TextArea(5,8)] private string[] dialogLines;

    [SerializeField, TextArea(5,8)] private string[] ans1;
    [SerializeField, TextArea(5,8)] private string[] ans2;

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

    }

    public struct Dialog
    {
        public string C1;
        public string C2;
    }
}
