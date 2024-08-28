using CQRS.Core.Messages;

namespace CQRS.Core.Events;

public abstract class BaseEvent:Message
{
    protected BaseEvent(string newType)
    {
        this.type = newType;
    }
    public string type { get; set; }
    public int version { get; set; }
}