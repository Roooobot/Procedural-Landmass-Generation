using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Data/CharacterData"), fileName= ("CharacterData_"))]
public class CharacterData : ScriptableObject
{
    [SerializeField] Texture2D characterAvataImage;
    [SerializeField] string characterName;
    [SerializeField,Range(1,characterMaxLevel)] int characterStartLevel = 1;
    [SerializeField] CharacterStats characterStats;

    int characterLevel;
    const int characterMaxLevel = 10;

    public Texture2D CharacterAvatarImage => characterAvataImage;
    public string CharacterName => characterName;
    public int CharacterLevel
    {
        get => characterLevel;
        set
        {
            if (characterLevel == value || value is < 1 or > characterMaxLevel) return;
            characterLevel = value;
        }
    }
    public CharacterStats CharacterStats => characterStats;

    private void OnEnable()
    {
        characterLevel = characterStartLevel;
    }
}
