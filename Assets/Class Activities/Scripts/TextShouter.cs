using UnityEngine;

public class TextShouter : MonoBehaviour
{
    private void Start()
    {
        TextEvents.OnAnnounceText?.Invoke("HIIIIIIIII FRIENDS");
    }
}
