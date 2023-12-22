using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SecondCharacter : Character
{
    [SerializeField] GameObject character;
    public override void ChangeSprite()
    {
        switch (dialogueShow.index)
        {
            case 21:
                character.SetActive(true);
                spriteRenderer.sprite = activeHappy;
                break;
            case 23:
                spriteRenderer.sprite = notActiveHappy;
                break;
            case 24:
                spriteRenderer.sprite = activeHappy;
                break;
            case 25:
                spriteRenderer.sprite = notActiveHappy;
                break;
            case 26:
                spriteRenderer.sprite = activeHappy;
                break;
            case 27:
                spriteRenderer.sprite = notActiveHappy;
                break;
            case 28:
                spriteRenderer.sprite = activeHappy;
                break;
            case 29:
                spriteRenderer.sprite = notActiveNeutral;
                break;
            case 32:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 33:
                spriteRenderer.sprite = activeHappy;
                break;
            case 35:
                spriteRenderer.sprite = notActiveHappy;
                break;
            case 43:
                spriteRenderer.sprite = activeHappy;
                break;
            case 44:
                spriteRenderer.sprite = notActiveHappy;
                break;
            case 46:
                spriteRenderer.sprite = activeHappy;
                break;
            case 48:
                spriteRenderer.sprite = notActiveHappy;
                break;
            case 50:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 51:
                character.SetActive(false);
                break;
            case 60:
                character.SetActive(true);
                spriteRenderer.sprite = activeHappy;
                break;
            case 61:
                spriteRenderer.sprite = notActiveHappy;
                break;
            case 62:
                spriteRenderer.sprite = activeFearOrSurprised;
                break;
            case 64:
                character.SetActive(false);
                break;
            case 71:
                character.SetActive(true);
                spriteRenderer.sprite = notActiveNeutral;
                break;
            case 74:
                spriteRenderer.sprite = activeNeutral;
                break;
            case 75:
                spriteRenderer.sprite = notActiveNeutral;
                break;
        }
    }
}
