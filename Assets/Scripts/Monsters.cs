using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class Monsters : MonoBehaviour
{
    
    public enum ColorType {
        Green,
        Blue,
        Red, 
        Black, 
        White
    };
    [Header("Monster Color Card")]
    public ColorType colorType;
    [Header("Card Stats")]
    public int attackStatus = 1;
    public int defenseStatus = 1;
    [Header("Card In Use")]
    public bool inUse;
    [Header("Mana Necessary")]
    public int neededMana;
    [Header("Monster Name")]
    public string monsterName;

    public Text mstNameText;
    public Text attText;
    public Text dffText;

    // Use this for initialization
    void Start() {

    }

	
	// Update is called once per frame
	void Update () {
        OnGui();
	}

    //public void CreateMosnter(ColorType type, int attack, int defense, int mana) {
    //    type = colorType;
    //    attack = attackStatus;
    //    defense = defenseStatus;
    //    inUse = false;
    //    mana = neededMana;
    //}

    void OnGui()
    {
        if (colorType == ColorType.Green)
        {
            mstNameText.color = Color.green;
            attText.color = Color.green;
            dffText.color = Color.green;
        }
        if (colorType == ColorType.Red)
        {
            mstNameText.color = Color.red;
            attText.color = Color.red;
            dffText.color = Color.red;
        }
        if (colorType == ColorType.Blue)
        {
            mstNameText.color = Color.blue;
            attText.color = Color.blue;
            dffText.color = Color.blue;
        }
        if (colorType == ColorType.White)
        {
            mstNameText.color = Color.white;
            attText.color = Color.white;
            dffText.color = Color.white;
        }
        if (colorType == ColorType.Black)
        {
            mstNameText.color = Color.black;
            attText.color = Color.black;
            dffText.color = Color.black;
        }
        mstNameText.text = monsterName;
        attText.text = "Attack Stats: " +  attackStatus.ToString();
        dffText.text = "Defense Stats: " + defenseStatus.ToString();
    }

}
