using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Image = UnityEngine.UI.Image;

public class Character : MonoBehaviour
{
    [SerializeField] internal Sprite activeHappy;
    [SerializeField] internal Sprite activeFearOrSurprised;
    [SerializeField] internal Sprite activeNeutral;

    [SerializeField] internal Sprite notActiveHappy;
    [SerializeField] internal Sprite notActiveFearOrSurprised;
    [SerializeField] internal Sprite notActiveNeutral;

    [SerializeField] internal Image spriteRenderer;

    public GameObject textPanel;
    internal DialogueShow dialogueShow;

    public void Start()
    {
        textPanel = GameObject.Find("TextPanel");
        dialogueShow = textPanel.GetComponent<DialogueShow>();
    }
    
    public virtual void ChangeSprite() { }


    


}



