using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueLog : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; //������ �� ��������, � ������� ���������� ����� �� �������
    public TextMeshProUGUI dialogueLog; //������ �� ��������, � ������� ����� ������������ ������ �� �������
    public GameObject dialogueLogPanel;


    public void AddToLog() //����� ����������� � ��� �� �����
    {
        dialogueLog.text += "\n" + dialogueText.text + "\n";
    }
}
