using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    [SerializeField] private string itemName = "New Item";
    public Sprite iconForUI = null;
    [SerializeField] private float costInDollars = 0;
    // Add more item-specific properties
}
