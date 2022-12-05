using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterDatapanel:VisualElement
{
    readonly TemplateContainer templateContainer;

    public new class UxmlFactory : UxmlFactory<CharacterDatapanel> { }
    public CharacterDatapanel()
    {
        templateContainer = Resources.Load<VisualTreeAsset>("CharacterDatapanel").Instantiate();
        templateContainer.style.flexGrow = 1f;
        hierarchy.Add(templateContainer);
    }
}
