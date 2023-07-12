using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDislplayer : MonoBehaviour
{
    public CardSO cardSO;


    public Image cardArt;
    public Image backgroundImage;
    public Color backImageColor;
    
    
    public Text northValueText,
        eastValueText,
        southValueText,
        westValueText;
    
    
    void Start()
    {
        cardArt.sprite = cardSO.cardArt;
        backgroundImage.sprite = cardSO.backgroundImage;
        
        northValueText.text = cardSO.northValue.ToString();
        eastValueText.text = cardSO.eastValue.ToString();
        southValueText.text = cardSO.southValue.ToString();
        westValueText.text = cardSO.westValue.ToString();
    }

}
