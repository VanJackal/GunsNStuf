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
        Attachments.Add(new Attachment("mod1"));
        Attachments.Add(new Attachment("mod2"));
        Attachments.Add(new Attachment("mod3"));
        Attachments.Add(new Attachment("mod4"));
    }

    public static Data GetInstance()
    {
        return Instance;
    }
}