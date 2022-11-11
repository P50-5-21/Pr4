namespace Пр4
{
    internal class Program
    {       
        public static int switching = 0;
        public static int a = 0;   // a и b и с просто переменные
        public static int b = 0;
        public static int c = 0;
        public static int position = 2;
        public static ConsoleKeyInfo switch_;
        static void Main(string[] args)
        {
            Switch();
        }
        static void Day_1()
        {
            List<string> day_11 = new List<string>();
            day_11.Add("Выбрана дата 11.11.2022");
            day_11.Add("------------------------------------------");
            day_11.Add("  1. Прийти на пары.");
            day_11.Add("  2. Поехать домой.");
            day_11.Add("  3. Сделать уроки.");

            foreach (string cho_to in day_11)
                Console.WriteLine(cho_to);
        }
        public static void Day_2()
        {
            List<string> day_12 = new List<string>();
            day_12.Add("Выбрана дата 12.11.2022");
            day_12.Add("------------------------------------------");
            day_12.Add("  1. Прийти на пары.");
            day_12.Add("  2. Поехать домой.");
            day_12.Add("  3. Пойти в зал.");


            foreach (string cho_to in day_12)
                Console.WriteLine(cho_to);
        }
        public static void Day_3()
        {
            List<string> day_13 = new List<string>();
            day_13.Add("Выбрана дата 13.11.2022");
            day_13.Add("------------------------------------------");
            day_13.Add("  1. Поспать очень долго.");
            
            foreach (string cho_to in day_13)
                Console.WriteLine(cho_to);
        }
        static void PodDay_0_1()
        {
            List<string> podDay_1 = new List<string>();
            podDay_1.Add("Прийти на пары");
            podDay_1.Add("------------------------------------------");
            podDay_1.Add("Описание: Прийти со 2 по 4 пару.");
            podDay_1.Add("Дата: 11.11.2022");
            foreach (string cho_to in podDay_1)
                Console.WriteLine(cho_to);
        }
        static void PodDay_1_1()
        {
            List<string> podDay_2 = new List<string>();
            podDay_2.Add("Поехать домой");
            podDay_2.Add("------------------------------------------");
            podDay_2.Add("Описание: С кайфом или без кайфа (когда как) поехать домой");
            podDay_2.Add("Дата: 11.11.2022");
            foreach (string cho_to in podDay_2)
                Console.WriteLine(cho_to);
        }
        static void PodDay_2_1()
        {
            List<string> podDay_3 = new List<string>();
            podDay_3.Add("Сделать уроки");
            podDay_3.Add("------------------------------------------");
            podDay_3.Add("Описание: С кайфом или без кайфа (когда как) сделать уроки");
            podDay_3.Add("Дата: 11.11.2022");
            foreach (string cho_to in podDay_3)
                Console.WriteLine(cho_to);
        }
        static void PodDay_0_2()
        {
            List<string> podDay_4 = new List<string>();
            podDay_4.Add("Прийти на пары");
            podDay_4.Add("------------------------------------------");
            podDay_4.Add("Описание: С 1 по 2 пару.");
            podDay_4.Add("Дата: 12.11.2022");
            foreach (string cho_to in podDay_4)
                Console.WriteLine(cho_to);
        }
        static void PodDay_1_2()
        {
            List<string> podDay_5 = new List<string>();
            podDay_5.Add("Поехать домой");
            podDay_5.Add("------------------------------------------");
            podDay_5.Add("Описание: С кайфом поехать домой.");
            podDay_5.Add("Дата: 12.11.2022");
            foreach (string cho_to in podDay_5)
                Console.WriteLine(cho_to);
        }
        static void PodDay_2_2()
        {
            List<string> podDay_6 = new List<string>();
            podDay_6.Add("Пойти в зал");
            podDay_6.Add("------------------------------------------");
            podDay_6.Add("Описание: Потренироваться, чтобы быть красивым и сносить тычки чертей");
            podDay_6.Add("Дата: 12.11.2022");
            foreach (string cho_to in podDay_6)
                Console.WriteLine(cho_to);
        }
        static void PodDay_1_3()
        {
            List<string> podDay_7 = new List<string>();
            podDay_7.Add("Поспать очень долго");
            podDay_7.Add("------------------------------------------");
            podDay_7.Add("Описание: После загруженной недели выспаться!");
            podDay_7.Add("Дата: 13.11.2022");
            foreach (string cho_to in podDay_7)
                Console.WriteLine(cho_to);
        }
        static void Switch()
        {
            Console.Clear();
            do
            {
                do
                {
                    if (switching == 0 && position == 2 && switch_.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodDay_0_1();
                        switch_ = Console.ReadKey();
                        if (switch_.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (switching == 0 && position == 3 && switch_.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodDay_1_1();
                        switch_ = Console.ReadKey();
                        if (switch_.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (switching == 0 && position == 4 && switch_.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodDay_2_1();
                        switch_ = Console.ReadKey();
                        if (switch_.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (switching == 1 && position == 2 && switch_.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodDay_0_2();
                        switch_ = Console.ReadKey();
                        if (switch_.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (switching == 1 && position == 3 && switch_.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodDay_1_2();
                        switch_ = Console.ReadKey();
                        if (switch_.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    else if (switching == 1 && position == 4 && switch_.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodDay_2_2();
                        switch_ = Console.ReadKey();
                        if (switch_.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    if (switching == 2 && position == 2 && switch_.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        PodDay_1_3();
                        switch_ = Console.ReadKey();
                        if (switch_.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                    
                } while (switch_.Key == ConsoleKey.Escape);
                switch (switching)
                {
                    case 0:
                        Console.Clear();
                        Day_1();
                        Swithingg_1();
                        return;
                    case 1:
                        Console.Clear();
                        Day_2();
                        Swithingg_1();
                        return;
                    case 2:
                        Console.Clear();
                        Day_3();
                        Swithingg_1();
                        return;

                }
                switch_ = Console.ReadKey();
                switch (switch_.Key)
                {
                    case ConsoleKey.LeftArrow:
                        switching--;
                        switch (switching)
                        {
                            
                            case -1:
                                Console.Clear();
                                switching = 2;
                                Day_3();
                                break;
                            case 0:
                                Console.Clear();
                                Day_1();
                                break;
                            case 1:
                                Console.Clear();
                                Day_2();
                                break;
                            case 2:
                                Console.Clear();
                                Day_3();
                                break;
                            
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        switching++;
                        switch (switching)
                        {
                            case 3:
                                Console.Clear();
                                switching = 0;
                                Day_1();
                                break;
                            case 0:
                                Console.Clear();
                                Day_1();
                                break;
                            case 1:
                                Console.Clear();
                                Day_2();
                                break;
                            case 2:
                                Console.Clear();
                                Day_3();
                                break;
                        }
                        break;
                }
            } while (switch_.Key == ConsoleKey.LeftArrow | switch_.Key == ConsoleKey.RightArrow);
            if (switch_.Key == ConsoleKey.Escape)
            {
                return;
            }
        }

        static void Swithingg_1()
        {
            Console.SetCursorPosition(0, position);
            Console.Write("->");
            do
            {
                switch_ = Console.ReadKey();
                if (switch_.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, position--);
                    if (switching == 0 && position == 1)
                    {
                        position++;
                    }
                    if (switching == 1 && position == 1)
                    {
                        position++;
                    }
                    if (switching == 2 && position == 1)
                    {
                        position++;
                    }
                    Console.Write("->");
                }
                else if (switch_.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, position++);
                    if (switching == 0 && position == a)
                    {
                        position--;
                    }
                    if (switching == 1 && position == b)
                    {
                        position--;
                    }
                    if (switching == 2 && position == c)
                    {
                        position--;
                    }
                    Console.Write("->");
                }
                Console.Write("\r" + new string(' ', 2) + "\r");
                Console.SetCursorPosition(0, position);
                Console.Write("->");
            } while (switch_.Key == ConsoleKey.UpArrow | switch_.Key == ConsoleKey.DownArrow);
            if (switch_.Key == ConsoleKey.LeftArrow | switch_.Key == ConsoleKey.RightArrow)
            {
                switch (switch_.Key)
                {
                    case ConsoleKey.LeftArrow:
                        switching--;
                        if (switching == -1)
                            switching = 2;
                        break;
                    case ConsoleKey.RightArrow:
                        switching++;
                        if (switching == 3)
                            switching = 0;
                        break;
                }
                Switch();
            }
            else if (switch_.Key == ConsoleKey.Enter)
            {
                Switch();
            }
            if (switch_.Key == ConsoleKey.Escape)
            {
                return;
            }
        }
    }
}
