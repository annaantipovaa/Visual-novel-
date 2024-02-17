using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueShow : MonoBehaviour
{
    public string[] dialogue;
    public float speedText;

    public TextMeshProUGUI dialogueText;
    public GameObject dialogueLog;
    private DialogueLog dl;

    [SerializeField] private Sprite background;
    [SerializeField] private Sprite background1;
    [SerializeField] private Sprite background2;
    [SerializeField] private Sprite background3;
    [SerializeField] private Sprite background4;
    [SerializeField] private Sprite background5;
    [SerializeField] private Sprite background6;
    [SerializeField] private Sprite background7;
    [SerializeField] private Sprite background8;

    [SerializeField] private Image spriteRenderer;

    [SerializeField] private GameObject finalScreen;
    [SerializeField] private GameObject finalText;
    [SerializeField] private GameObject finalButton;

    public int index;

    public void Start()
    {
        dialogueText.text = string.Empty;
        dialogueLog = GameObject.Find("LogController");
        dl = dialogueLog.GetComponent<DialogueLog>();
        StartDialogue();

    }

    IEnumerator TypeLine() 
    {
        foreach(char c in dialogue[index].ToCharArray()) 
        { 
            dialogueText.text += c;
            yield return new WaitForSeconds(speedText);
        }
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    public void SkipTextClick()
    {
        if(dialogueText.text == dialogue[index])
        {
            Next();
        }
        else 
        { 
            StopAllCoroutines();
            dialogueText.text = dialogue[index];
        }
    }

    public void Next()
    {
        if(index < dialogue.Length-1)
        {
            index++;
            dl.AddToLog();
            dialogueText.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);    
        }
    }


    public void ChangeBackground()
    {
        switch (index)
        {
            case 3:
                spriteRenderer.sprite = background;
                break;
            case 6:
                spriteRenderer.sprite = background1;
                break;
            case 8:
                spriteRenderer.sprite = background2;
                break;
            case 12:
                spriteRenderer.sprite = background3;
                break;
            case 16:
                spriteRenderer.sprite = background4;
                break;
            case 19:
                spriteRenderer.sprite = background5;
                break;
            case 35:
                spriteRenderer.sprite = background6;
                break;
            case 41:
                spriteRenderer.sprite = background5;
                break;
            case 50:
                spriteRenderer.sprite = background4;
                break;
            case 52:
                spriteRenderer.sprite = background7;
                break;
            case 54:
                spriteRenderer.sprite = background8;
                break;
            case 56:
                spriteRenderer.sprite = background2;
                break;
            case 59:
                spriteRenderer.sprite = background4;
                break;
            case 65:
                spriteRenderer.sprite = background7;
                break;
            case 66:
                spriteRenderer.sprite = background2;
                break;
            case 71:
                spriteRenderer.sprite = background4;
                break;
        }
    }

    /*public void Endings()
   {
       if(index == 76)
       {
           character2's sprite 
           choice buttons 
           if(button1)
           {
               finalScreen.SetActive(true);
               finalText.SetActive(true);
               finalButton.SetActive(true); //first ending 
           }
           else if(button2) //second ending 
           {
               SceneManager.LoadScene(2);
           }
       }
   }*/

    public void FinalScreen() //delete later 
    {
        if(index == 76)
        {
            finalScreen.SetActive(true);
            finalText.SetActive(true);
            finalButton.SetActive(true);
        }
    }

    public void FinishGame()
    {
        SceneManager.LoadScene(0);
    }
}
