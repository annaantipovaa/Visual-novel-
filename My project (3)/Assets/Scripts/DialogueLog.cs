using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueLog : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; //ссылка на текстмеш, в который передаютс€ фразы из диалога
    public TextMeshProUGUI dialogueLog; //ссылка на текстмеш, в который будут передаватьс€ строки из префаба
    public GameObject dialogueLogPanel;


    public void AddToLog() //фразы добавл€ютс€ в лог по клику
    {
        dialogueLog.text += "\n" + dialogueText.text + "\n";
    }
}
