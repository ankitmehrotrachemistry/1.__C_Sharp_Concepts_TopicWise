using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern2
{
    abstract class Observer
    {
        public abstract void notify(string eventName, object eventValue);
    }

    abstract class Observable
    {
        protected Dictionary<Observer, string> _observers = new Dictionary<Observer, string>();

        public void attach(Observer observer, string eventName = null)
        {
            this._observers.Add(observer, eventName);
        }

        public void detach(Observer observer)
        {
            this._observers.Remove(observer);
        }

        public void notify(string eventName, object eventValue)
        {
            foreach (Observer key in _observers.Keys)
            {
                if (_observers[key] == eventName)
                {
                    key.notify(eventName, eventValue);
                }
            }
        }
    }

    class UserObject
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
    }

    class Users : Observable
    {
        public const string ADD_USER = "addUser";
        public const string REMOVE_USER = "removeUser";
        public const string ERROR = "errorUser";

        protected Dictionary<string, UserObject> _users = new Dictionary<string, UserObject>();

        public void addUser(string username, string email, string address, string postcode)
        {
            UserObject user = new UserObject()
            {
                Address = address,
                Email = email,
                Postcode = postcode,
                Username = username
            };
            _users.Add(username, user);
            this.notify(ADD_USER, user);
        }

        public void removeUser(string username)
        {
            if (_users.ContainsKey(username))
            {
                this.notify(REMOVE_USER, _users[username]);
                _users.Remove(username);
            }
            else
            {
                this.notify(ERROR, "removing user failed, username not found " + username);
            }
        }
    }

    class SendEmailToNewUsers : Observer
    {
        public override void notify(string eventName, object eventValue)
        {
            if (eventName == Users.ADD_USER)
            {
                Console.WriteLine("[sendmail] Added a user, sending email to " + ((UserObject)eventValue).Email);
            }
            else if (eventName == Users.REMOVE_USER)
            {
                Console.WriteLine("[sendmail] Removed a user, sending email to " + ((UserObject)eventValue).Email);
            }
        }
    }

    class WelcomeNewUser : Observer
    {
        public override void notify(string eventName, object eventValue)
        {
            Console.WriteLine("[welcome] Welcome aboard, " + ((UserObject)eventValue).Username + "!");
        }
    }

    class ErrorUser : Observer
    {
        public override void notify(string eventName, object eventValue)
        {
            Console.WriteLine("[error] There was an error: " + eventValue.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting test");

            Users users = new Users();

            users.attach(new SendEmailToNewUsers());
            users.attach(new WelcomeNewUser(), Users.ADD_USER);
            users.attach(new ErrorUser(), Users.ERROR);

            users.addUser("Ian Ross", "ianross@gmail.xxx", "66 London Street", "PE1 2RF");
            users.addUser("Mike Smith", "mikes@gmail.xxx", "123 Main Road", "PE2 6FX");
            users.removeUser("Ian Ross");
            users.addUser("John Wayne", "jwayne@gmail.xxx", "999 Kansas Road", "LE5 5AZ");
            users.removeUser("Anthony McQuinn");
            users.removeUser("John Wayne");

            Console.WriteLine("End test");
        }
    }

}
