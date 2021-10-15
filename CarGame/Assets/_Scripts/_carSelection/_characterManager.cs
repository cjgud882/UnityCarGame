using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _characterManager : MonoBehaviour
{
    public _characterDatabase characterDB;
    
    public Text nameText;
    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextOption()
    {
        selectedOption++;
        
        if (selectedOption >= characterDB.characterCount)
        {
            selectedOption = 0;
        }
    }

    private void UpdateCharacter(int selectedOption)
    {
        _character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }
}
