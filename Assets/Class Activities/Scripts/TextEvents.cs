using UnityEngine;

public class TextEvents : MonoBehaviour
{
    /// <summary>
    /// Defines the kind of event. In this case, one with a text string.
    /// </summary>
    /// <param name="messageToSend">The string that we want to announce.</param>
    public delegate void TextAnnouncerDelegate(string messageToSend);

    public delegate void EventTypeThatHasNoParameters();

    /// <summary>
    /// The event we are announcing.
    /// </summary>
    public static TextAnnouncerDelegate OnAnnounceText;

    public static EventTypeThatHasNoParameters OnEventWithoutParameters;
}
