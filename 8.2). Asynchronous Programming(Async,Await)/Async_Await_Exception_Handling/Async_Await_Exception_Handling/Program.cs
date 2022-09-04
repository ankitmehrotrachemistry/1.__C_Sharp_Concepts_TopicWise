using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await_Exception_Handling
{
    class Program
    {
        private string _text = "Ankit";
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public void MainFunction()
        {
            DoSomething().Await(Completed, HandleError);
        }
        private void Completed()
        {
            Console.WriteLine("Completed"+Text);
            Text = "Completed";
        }
        private void HandleError(Exception ex)
        {
            Text = ex.Message;
        }
        async Task DoSomething()
        {
            await Task.Delay(4000);
            Text = "New Task";
            Console.WriteLine("Do Something" +Text);
            throw new Exception("Thrown in Task");
        }
        static void Main(string[] args)
        {

        }
    }
    public static class TaskExtensions
    {
        public async static void Await(this Task task, Action completedCallback, Action<Exception> errorCallBack)
        {
            try
            {
                await task;
                completedCallback?.Invoke();
            }
            catch (Exception ex)
            {
                errorCallBack?.Invoke(ex);
            }
        }
    }
}
