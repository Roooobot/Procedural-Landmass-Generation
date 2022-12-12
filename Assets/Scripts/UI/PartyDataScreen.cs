using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PartyDataScreen : MonoBehaviour
{
    VisualElement rootVisualElement;
    [SerializeField]PartyData partyData;
    private void Awake()
    {
        rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
        var bodyContainer = rootVisualElement.Q("BodyContainer");
        bodyContainer.Clear();

        foreach(CharacterData characterData in partyData.CharacterDataList)
        {
            var characterDataPannel = new CharacterDatapanel(characterData);
            characterDataPannel.style.flexBasis = Length.Percent(25.0f);
            bodyContainer.Add(characterDataPannel);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rootVisualElement.style.display=
                rootVisualElement.style.display == DisplayStyle.Flex?DisplayStyle.None:DisplayStyle.Flex;
        }
    }
}
