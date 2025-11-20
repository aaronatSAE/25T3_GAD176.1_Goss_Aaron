using UnityEngine;

/// <summary>
/// Have an event that announces at a certain time (OnStart).
/// Have objects that respond when that event is announced (will print to the console text that says "Event has triggered!").
/// </summary>
public class TextListener : MonoBehaviour
{
    private void OnEnable()
    {
        TextEvents.OnAnnounceText += ShoutAnnouncement;
        TextEvents.OnAnnounceText += WhisperAnnouncement;
    }

    //private void Start()
    //{
    //    // invoke the event
    //    TextEvents.OnAnnounceText?.Invoke("Hello, World!");
    //}

    private void OnDisable()
    {
        TextEvents.OnAnnounceText -= ShoutAnnouncement;
        TextEvents.OnAnnounceText -= WhisperAnnouncement;
    }

    private void ShoutAnnouncement(string announcementToShout)
    {
        Debug.Log("HEEEEEEEEEEY! " + announcementToShout);
    }

    private void WhisperAnnouncement(string announcementToWhisper)
    {
        Debug.Log("I am whispering to you! " + announcementToWhisper);
    }
}
