using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Card", menuName = "Card SO")]

public class CardSO : ScriptableObject
{
    public string cardName;

    public Sprite cardArt;
    
    public int northValue,
        eastValue,
        southValue,
        westValue;
}
