using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Txt_System : MonoBehaviour
{
    public Image C1;
    public Image C2;
    public Text N1;
    public Text N2;
    public Text dialogue;
    public GameObject window;

    [Range(0, 10)]
    public float txtSpeed = 10;
    private float realTimeSpeed = 0;
    public int dialoguePos;
    public Dialogue[] dialogues;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadDialogue(Dialogue[] _ds)
    {
        dialogues = _ds;
        StopAllCoroutines();
        window.SetActive(false);
    }

    public void startDialogue()
    {
        window.SetActive(true);
        dialoguePos = 0;
    }

    public void showDialogue(int pos)
    {
        speedText();
        StopAllCoroutines();
        StartCoroutine(runDialogue(dialogues[pos]));
    }

    private void speedText()
    {
        realTimeSpeed = 100 / txtSpeed;
        Debug.Log(realTimeSpeed + "s");
    }

    public void next()
    {
        dialoguePos++;
        if (dialoguePos >= dialogues.Length)
        {
            finish();
            return;
        }
        showDialogue(dialoguePos);
    }

    public void back()
    {
        dialoguePos--;
        dialoguePos = dialoguePos < 0 ? 0 : dialoguePos;
        showDialogue(dialoguePos);
    }

    public void finish()
    {
        window.SetActive(false);
    }

    public IEnumerator runDialogue(Dialogue conv)
    {
        string txt = conv.content;
        C1.sprite = conv.C1;
        C2.sprite = conv.C2;
        N1.text = conv.N1;
        N2.text = conv.N2;
        char[] leters = txt.ToCharArray();
        for (int X = 0; X < leters.Length; X++)
        {
            dialogue.text += leters[X];
            yield return new WaitForSeconds(txtSpeed);
        }
    }

    [System.Serializable]
    public struct Dialogue
    {
        public string N1;
        public string N2;
        public Sprite C1;
        public Sprite C2;
        public string content;
    }
}