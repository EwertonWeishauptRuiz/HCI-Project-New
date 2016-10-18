using UnityEngine;
using System.Collections;

public class Mana : MonoBehaviour {

    public enum ManaType {
        Green,
        Blue,
        Red,
        Black,
        White
    }

    public int playerManaCount = 0;
    public bool inUse;

    public int manaInUse = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddMana(ManaType type) {
        type = ManaType.Green;
        playerManaCount++;
        inUse = false;
    }

    public void ManaInUse (){
        inUse = true;
        manaInUse++;
    }

    public void ManaNotInUse()
    {
        inUse = false;
        manaInUse--;
    }

}
