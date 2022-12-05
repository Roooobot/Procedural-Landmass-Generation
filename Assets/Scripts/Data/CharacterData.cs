using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("Data/CharacterData"), fileName= ("CharacterData_"))]
public class CharacterData : ScriptableObject
{
    [SerializeField] Texture2D characterAvataImage;
    [SerializeField] string characterName;
    [SerializeField] int characterStartLevel = 1;
    [SerializeField] CharacterStats characterStats;
    public Texture2D CharacterAvatarImage => CharacterAvatarImage;
    public string CharacterName => characterName;
    public int CharacterStartLevel => characterStartLevel;
    public CharacterStats CharacterStats => characterStats;
}
