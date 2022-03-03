using System;
using System.Collections.Generic;

namespace CSharpBasicInterfaces {

    interface IStorable {
        void Save();
        void Load();
        bool NeedsSave {get; set;} 
    }

    class Document : IStorable {

        private string name;

        public Document(string s) {
            name = s;
            Console.WriteLine("Document created with name '{0}'", name);
        }

        public void Save() {
            Console.WriteLine("Saving document)");
        }

        public void Load() {
            Console.WriteLine("Loading document");
        }

        public bool NeedsSave {
            get; set;
        }
    } // End class Document

    public class Program {

        public static void Main(string[] args) {

            Document d = new Document("Test Document");
            d.Load();
            d.Save();
            d.NeedsSave = false;

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

}