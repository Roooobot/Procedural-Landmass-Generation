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
