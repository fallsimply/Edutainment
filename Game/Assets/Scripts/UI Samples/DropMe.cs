using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {
	public Image containerImage;
	public Image receivingImage;
	private Color normalColor;
	public Color highlightColor = Color.yellow;
	[HideInInspector()]
	public bool disabled = false;
	public SortController SortController;

	public void OnEnable() {
		if (containerImage != null)
			normalColor = containerImage.color;
	}

	public void OnDrop(PointerEventData data) {
		if (disabled | receivingImage == null) return;

		containerImage.color = normalColor;

		Sprite dropSprite = GetDropSprite(data);
		if (dropSprite != null) {
			receivingImage.overrideSprite = dropSprite;
			if (data.pointerDrag.tag == this.tag) {
				data.pointerDrag.SendMessage("disable");
				disabled = true;

				GameObject newobj = Instantiate(data.pointerDrag.gameObject);
				newobj.transform.SetParent(this.transform.parent);
				newobj.transform.position = this.transform.position;

				SortController.Inventory.Add(this.tag);
				SortController.CheckFinish();
				//= data.pointerDrag.gameObject;
			}
		}
	}

	public void OnPointerEnter(PointerEventData data) {
		if (disabled | containerImage == null) return;

		Sprite dropSprite = GetDropSprite(data);
		if (dropSprite != null)
			containerImage.color = highlightColor;
	}

	public void OnPointerExit(PointerEventData data) {
		if (containerImage == null) return;

		containerImage.color = normalColor;
	}

	private Sprite GetDropSprite(PointerEventData data) {
		var originalObj = data.pointerDrag;
		if (originalObj == null)
			return null;

		var dragMe = originalObj.GetComponent<DragMe>();
		if (dragMe == null)
			return null;

		var srcImage = originalObj.GetComponent<Image>();
		if (srcImage == null)
			return null;

		return srcImage.sprite;
	}
}
