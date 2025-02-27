namespace core;


public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            DisplayMainMenu();

            int choice = GetFigureChoice();

            switch (choice)
            {
                case 1:
                    DrawLine();
                    break;
                case 2:
                    Exit();
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите фигуру из меню.");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в главное меню...");
            Console.ReadKey();
        }
    }

    private static int GetFigureChoice()
    {
        while (true)
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
                return choice;
            else
                Console.Write("Некорректный ввод. Пожалуйста, введите число.\n[ + ] Выберите фигуру: ");
        }
    }


    private static void DrawLine()
    {
        Console.Clear();
        Console.WriteLine(
            "[ + ] Фигура: “Линия”\n\n" + 
            "[ 1 ] Горизонтальная\n" +
            "[ 2 ] Вертикальная\n"
        );

        Console.Write("[ + ] Выберите тип: ");
        int type = GetLineType();

        Console.Write("[ + ] Длина линии: ");
        int length = GetLineLength();

        Console.Write("[ + ] Текстура линии: ");
        char texture = GetLineTexture();

        Console.WriteLine("\n[ + ] Результат:\n");

        if (type == 1)
        {
            for (int i = 0; i < length; i++)
                Console.Write(texture + "  ");

            Console.WriteLine();
        }
        else if (type == 2)
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine(texture);
        }
    }

    private static int GetLineType()
    {
        while (true)
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int type) && (type == 1 || type == 2))
                return type;
            else
                Console.Write("Некорректный ввод. Пожалуйста, введите 1 или 2.\n[ + ] Выберите тип: ");
        }
    }

    private static int GetLineLength()
    {
        while (true)
        {
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int length) && length > 0)
                return length;
            else
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.\n[ + ] Длина линии: ");
        }
    }

    private static char GetLineTexture() => Console.ReadKey().KeyChar;


    private static void DisplayMainMenu() => Console.WriteLine(
        "[ + ] Программа - “Геометрические фигуры”\n\n" +
        "[ 1 ] Линия\n" +
        "[ 2 ] Завершить программу\n\n" +
        "[ + ] Выберите фигуру: "
    );


    private static void Exit()
    {
        Console.Clear();
        Console.WriteLine("Завершение программы.\n");
    }
}