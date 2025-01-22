using GunsNStuf.Data.Models;
using GunsNStuf.Data.Registries;

namespace GunsNStuf.Data;

public class Data
{
    private static readonly Data Instance = new();

    public Registry<Attachment> Attachments { get; } = new();

    private Data()
    {
        // Initialize Registry
        // todo this should be converted so its reading in from jsons(or some kind of dynamic list from the attachments) for each registry
        Attachments.Add(new Attachment("sample","res://Assets/Sprites/icon.svg"));
        Attachments.Add(new Attachment("flashlight","res://Assets/Sprites/flashlight.png"));
        Attachments.Add(new Attachment("foregrip","res://Assets/Sprites/Foregrip.png"));
        Attachments.Add(new Attachment("sight","res://Assets/Sprites/sight.png"));
    }

    public static Data GetInstance()
    {
        return Instance;
    }
}