using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using BreakInfinity;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public GameController GameController;
    public BigDouble levelRequierment = 2;
    public float fillNumber = 0;
    public Image fill;
    public TMP_Text text;
    public TMP_Text levelText;

    public Levels()
    {
        
    }

    public void LevelUp()
    {
        GameController.data.level++;
        GameController.data.exp -= levelRequierment;
        if (GameController.data.level <= 20)
            levelRequierment += levelRequierment * 0.2 * GameController.expRequirementDecrease;
        else if (GameController.data.level <= 200)
            levelRequierment += levelRequierment * 0.25 * GameController.expRequirementDecrease;
        else
            levelRequierment += levelRequierment * 0.5 * GameController.expRequirementDecrease;
        
        if (GameController.data.maxLevel < GameController.data.level)
        {
            GameController.data.maxLevel = GameController.data.level;
        }
    }
}
