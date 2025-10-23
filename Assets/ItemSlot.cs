using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private ItemData itemReference;
    [SerializeField] private Image image;

    private void Start()
    {
        image.sprite = itemReference.iconForUI;
    }
}
