using System;

namespace ObserverPattern.Subject;

public class Newsletter
{
    public String Topic { get; set; }
    public String Content { get; set; }

    public Newsletter(String topic, String content)
    {
        Topic = topic;
        Content = content;
    }
}

