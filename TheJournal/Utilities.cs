using System;
using System.Collections.Generic;
using System.IO;

namespace TheJournal
{
    static class Utilities
    {
        private static string _userAnswer;
        private static DateTime dateHour;
        private static string _datePromptAnswer;
        private static string _promptAle;
        private static string _fileName;
        private static string _path;
        private static string directoryPath;
        private static string _readfile;

        public static void Write()
        {
            _promptAle = PromtBank.GetRandomPrompt();
            Console.WriteLine(_promptAle);
            _userAnswer = Console.ReadLine();
        }

        public static void Display()
        {
            dateHour = DateTime.Now;
            string dateHourString = dateHour.ToString();
            _datePromptAnswer = $"{dateHourString} \n- Prompt: {_promptAle}, \nAnswer: {_userAnswer}";
            Console.WriteLine($"What time is it? {_datePromptAnswer}");
        }

        public static void Load()
        {
            Console.WriteLine("Enter the name of the file to load:");
            string fileName = Console.ReadLine();
            //string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            if (File.Exists(_path))
            {
                string content = File.ReadAllText(_path);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        public static void Save()
        {
            Console.WriteLine("Enter the name of the file without an extension (e.g., myjournal):");
            _fileName = Console.ReadLine() + ".txt";

            directoryPath = Directory.GetCurrentDirectory();
            _path = Path.Combine(directoryPath, _fileName);
            string content = _datePromptAnswer;

            File.WriteAllText(_path, content);

            Console.WriteLine("File saved at: " + _path);
        }

        public static void Quit()
        {
            Console.WriteLine("Thank you for using the promagram");
        }
    }
}
