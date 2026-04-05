public interface IObserver
{
    void Update(string newsTitle);
}

public interface IObservable
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

public class NewsPublisher : IObservable
{
    private List<IObserver> observers = new List<IObserver>();
    private string lastNews = "";

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
        Console.WriteLine($"New subscriber added. Total subscribers: {observers.Count}");
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
        Console.WriteLine($"One subscriber removed. Total subscribers: {observers.Count}");
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(lastNews);
        }
    }

    public void PublishNews(string title)
    {
        Console.WriteLine($"\nNews: {title}");
        lastNews = title;
        NotifyObservers();
    }
}

public class EmailSubscriber : IObserver
{
    private string email;

    public EmailSubscriber(string email)
    {
        this.email = email;
    }

    public void Update(string newsTitle)
    {
        Console.WriteLine($"Sended on email {email}: '{newsTitle}'");
    }
}

public class SmsSubscriber : IObserver
{
    private string phoneNumber;

    public SmsSubscriber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public void Update(string newsTitle)
    {
        Console.WriteLine($"Sended SMS on nuber {phoneNumber}: '{newsTitle}'");
    }
}

public class PushSubscriber : IObserver
{
    private string deviceId;

    public PushSubscriber(string deviceId)
    {
        this.deviceId = deviceId;
    }

    public void Update(string newsTitle)
    {
        Console.WriteLine($"Sended Push-message on device {deviceId}: '{newsTitle}'");
    }
}
