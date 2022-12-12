using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterDatapanel:VisualElement
{
    readonly TemplateContainer templateContainer;

    readonly List<VisualElement> statContainers;

    public new class UxmlFactory : UxmlFactory<CharacterDatapanel> { }
    public CharacterDatapanel()
    {
        templateContainer = Resources.Load<VisualTreeAsset>("CharacterDatapanel").Instantiate();
        templateContainer.style.flexGrow = 1f;
        hierarchy.Add(templateContainer);
    }

    public CharacterDatapanel(CharacterData characterData):this()
    {
        userData = characterData;
        templateContainer.Q("Avatar").style.backgroundImage = characterData.CharacterAvatarImage;
        templateContainer.Q<Label>("NameLabel").text = characterData.CharacterName;

        statContainers = templateContainer.Query("StatContainer").ToList();

        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        var characterData = (CharacterData)userData;
        SetCharacterStat(statContainers[0],"�ȼ�",characterData.CharacterLevel);
        SetCharacterStat(statContainers[1],"�ж���",characterData.CharacterStats.initiative);
        SetCharacterStat(statContainers[2],"���HP", characterData.CharacterStats.maxHP);
        SetCharacterStat(statContainers[3], "���MP", characterData.CharacterStats.maxMP);
        SetCharacterStat(statContainers[4],"������", characterData.CharacterStats.attack);
        SetCharacterStat(statContainers[5],"������", characterData.CharacterStats.defense);
    }
    void SetCharacterStat(VisualElement statContainers, string titleText, int value)
    {
        statContainers.Q<Label>("StatTitleLabel").text = titleText;
        statContainers.Q<Label>("StatValueLabel").text = value.ToString();
    }
}
