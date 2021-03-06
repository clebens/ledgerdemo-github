﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ledgerdemo.ConsoleApp.Helpers {
    public static class PromptGenerator {
        private static string ReadLineHidden() {
            string input = "";
            while (true) {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                else input += key.KeyChar;
            }
            return input;
        }

        public static string Menu(List<string> items, string title=null) {
            var str = "\n\n";
            if (title != null) str += $"--- {title} ---\n";
            for (var i = 0; i < items.Count; i++) {
                str += $"{i + 1}. {items[i]}\n";
            }
            str += "(0 to exit) -> ";
            Console.Write(str);
            return Console.ReadLine();
        }

        public static string Input(string entry, bool hide = false) {
            Console.WriteLine($"\n\n{entry}: ");
            return (hide) ? ReadLineHidden() : Console.ReadLine();
        }
    }
}
