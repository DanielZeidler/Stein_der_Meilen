using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class schriftDropzone : MonoBehaviour, IDropHandler
{
	void Start() {
		font = Resources.Load<Font>("Fonts/Hieroglify");
	}

	public Counter counter;
		
	Text text;

	Font font;


	public void OnDrop (PointerEventData eventData)
	{
		if (eventData.pointerDrag.name == gameObject.name)
		{
			eventData.pointerDrag.gameObject.SetActive (false);
			text = gameObject.GetComponentInChildren<Text> ();
			text.font = font;
			counter.addCount();
			print (counter.getCount());
		}
		if (counter.won()) {
			// Win Game
			print("You Won");
            GameManager.Instance.finishMinispiel3 = true;
            if (StoryContainer.accessStoryPart < 6)
            {
                StoryContainer.accessStoryPart = 6;
                StoryContainer.actTextbaustein += 1;
                StoryContainer.actLetter = 0;
                StoryContainer.actText = "";
            }
        }
	}
}