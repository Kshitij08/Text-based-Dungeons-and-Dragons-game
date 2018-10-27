using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "TextAdventure/InputActions/Examine")]
public class Examine : InputAction 
{
	public override void RespondToInput (GameController controller, string[] seperatedInputWords)
	{
		controller.LogStringWithReturn (controller.TestVerbeDictionaryWithNoun (controller.interactableItems.examineDictionary, seperatedInputWords [0], seperatedInputWords [1]));
	}
}
