using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            var privateKey = Console.ReadLine();
            var messages = new List<Message>();
            var rgx = new Regex(@"^TO: ([A-Z]+); MESSAGE: (.+);$");
            string input;
            while (!(input = Console.ReadLine()).Equals("END"))
            {
                var m = rgx.Match(input);
                if (m.Success)
                    messages.Add(new Message(m.Groups[1].Value, m.Groups[2].Value));
            }

            var sorted = messages
            .OrderBy(m => m.Sender);
            foreach (var message in sorted)
            {
                var encrypted = Message.Encrypt(message, privateKey);
                Console.WriteLine(encrypted);
            }
        }
    }

    public class Message
    {
        public Message(string sender, string content)
        {
            Sender = sender;
            Content = content;
        }

        public string Sender { get; }
        public string Content { get; }

        public static string Encrypt(Message message, string privateKey)
        {
            var toEncrypt = $"TO: {message.Sender}; MESSAGE: {message.Content};";
            var result = new StringBuilder(toEncrypt.Length);
            var keyIndex = 0;
            foreach (var letter in toEncrypt)
                result.Append((char)(letter + privateKey[keyIndex++ % privateKey.Length] - 48));

            return result.ToString();
        }
    }
}