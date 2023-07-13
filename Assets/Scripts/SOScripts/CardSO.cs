using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "new Card", menuName = "Card SO")]

public class CardSO : ScriptableObject
{
    public string cardName;

    public Sprite cardArt;
    public Sprite backgroundImage;
    public Color backImageColor;
    
    public int rank;
    
    //number/power value of card on each cardinal direction
    public int northValue,
        eastValue,
        southValue,
        westValue;
}
