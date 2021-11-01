using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class _characterDatabase : ScriptableObject
{
    public _character[] character;

    public int characterCount
    {
        get
        {
            return character.Length;
        }
    }

    public _character GetCharacter(int Index)
    {
        return character[Index];
    }
}

