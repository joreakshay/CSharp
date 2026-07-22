using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ObserverPattern
{
    //Subject class Chanel
    public class Chanel
    {
        private List<ISubscriber> subscribers=new List<ISubscriber>();
        private string currentVideoName;
        public void Subscribe(ISubscriber subscriber)
        {
            if(subscribers.Contains(subscriber)) return;
            subscribers.Add(subscriber);
        }
        public void UnSubscribe(ISubscriber subscriber)
        {
            if (!subscribers.Contains(subscriber)) return;
            subscribers.Remove(subscriber);
        }
        public void AddNewVideo(string videoName)
        {
            currentVideoName = videoName;
            UpdateAll();
        }

        private void UpdateAll()
        {
            foreach(ISubscriber subscriber in subscribers)
            {
                subscriber.SendNotification(currentVideoName);
            }
        }
    }

    public interface ISubscriber
    {
        void SendNotification(string message);
    }

    public class Subscriber : ISubscriber
    {
        private string userName;
        public Subscriber(string nmae)
        {
            userName = nmae;
        }
        public void SendNotification(string message)
        {
            Console.WriteLine("Recived notification for {0} Added video {1}",userName, message);
        }
    }

    public class ObserverPattern
    {
        public static void Main()
        {
            Chanel abcVideo = new Chanel();
            ISubscriber s1=new Subscriber("Akshay");
            ISubscriber s2 = new Subscriber("Aarti");
            ISubscriber s3 = new Subscriber("Siya");

            abcVideo.Subscribe(s1);
            abcVideo.Subscribe(s2);
            abcVideo.Subscribe(s3);

            abcVideo.AddNewVideo("Tom and Jerry");

            abcVideo.UnSubscribe(s3);

            abcVideo.AddNewVideo("Pune news");
        }
    }
}
