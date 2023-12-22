using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MainCharacter : Character
{
    public override void ChangeSprite()
    {
        switch (dialogueShow.index)
        {
            case 3:
                spriteRenderer.sprite = activeFearOrSurprised;
                break;
            case 6:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 14:
                spriteRenderer.sprite = activeFearOrSurprised;
                break;
            case 16:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 21:
                spriteRenderer.sprite = notActiveHappy;
                break;
            case 23:
                spriteRenderer.sprite = activeHappy;
                break;
            case 24:
                spriteRenderer.sprite = notActiveNeutral;
                break;
            case 25:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 26:
                spriteRenderer.sprite = notActiveNeutral;
                break;
            case 27:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 28:
                spriteRenderer.sprite = notActiveNeutral;
                break;
            case 29:
                spriteRenderer.sprite = activeFearOrSurprised;
                break;
            case 32:
                spriteRenderer.sprite = notActiveNeutral;
                break;
            case 35:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 43:
                spriteRenderer.sprite = notActiveNeutral;
                break;
            case 44:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 46:
                spriteRenderer.sprite = notActiveHappy;
                break;
            case 48:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 50:
                spriteRenderer.sprite = notActiveNeutral;
                break;
            case 51:
                spriteRenderer.sprite = activeHappy;
                break;
            case 56:
                spriteRenderer.sprite = activeFearOrSurprised;
                break;
            case 60:
                spriteRenderer.sprite = notActiveFearOrSurprised;
                break;
            case 61:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 62:
                spriteRenderer.sprite = notActiveNeutral;
                break;
            case 64:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 67:
                spriteRenderer.sprite = activeFearOrSurprised;
                break;
            case 74:
                spriteRenderer.sprite = notActiveFearOrSurprised;
                break;
            case 75:
                spriteRenderer.sprite = activeFearOrSurprised;
                break;
            default:
                break;
        }

    }
}
