using System.Text;

public struct UserInfo()
{
    public string userName;
    public string userPlace;
    public int userAge;
    public string userPin;
    public void Output()
    {
        Console.WriteLine("Имя пользователя:{0}\nГород пользователя:{1}", userName, userPlace);
        Console.WriteLine("Возраст пользователя:{0}\nPIN-код пользователя:{1}", userAge, userPin);
    }
}
public struct Student
{
    public string lastName;
    public string firstName;
    public string idenityNumber;
    public string birthDate;
    public string alcoholismCategory;
    public Drink studentDrink;
    public double drunkVolume;
    public double overall;
    public double overallAlcohol;
}
public struct Drink
{
    public string drinkName;
    public double alcoholPercent;
}
public class Tasks
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        void StartTask(int n)
        {
            Console.WriteLine("Задание {0}", n);
        }

        //1.Выведите на экран информацию о каждом типе данных в виде:
        //Тип данных – максимальное значение – минимальное значение
        StartTask(1);
        Console.WriteLine("о каждом типе данных в виде:\nТип данных – максимальное значение – минимальное значение");
        Console.WriteLine("Char - {1} - {0}", (int)char.MinValue, (int)char.MaxValue);
        Console.WriteLine("Float - {1} - {0}", float.MinValue, float.MaxValue);
        Console.WriteLine("Double - {1} - {0}", double.MinValue, double.MaxValue);
        Console.WriteLine("Decimal - {1} - {0}", decimal.MinValue, decimal.MaxValue);
        Console.WriteLine("Byte - {1} - {0}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("Sbyte - {1} - {0}", sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("Short - {1} - {0}", short.MinValue, short.MaxValue);
        Console.WriteLine("Ushort - {1} - {0}", ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("Int - {1} - {0}", int.MinValue, int.MaxValue);
        Console.WriteLine("Uint - {1} - {0}", uint.MinValue, uint.MaxValue);
        Console.WriteLine("Long - {1} - {0}", long.MinValue, long.MaxValue);
        Console.WriteLine("Ulong - {1} - {0}", ulong.MinValue, ulong.MaxValue);


        StartTask(2);
        //2.Напишите программу, в которой принимаются данные пользователя в виде имени,
        //города, возраста и PIN-кода.Далее сохраните все значение в соответствующей
        //переменной, а затем распечатайте всю информацию в правильном формате.
        UserInfo user1 = new UserInfo();
        Console.WriteLine("принимаются данные пользователя в виде имени,");
        Console.WriteLine("города, возраста и PIN-кода");
        Console.WriteLine("Введите имя");
        user1.userName = Console.ReadLine();
        Console.WriteLine("Введите Город");
        user1.userPlace = Console.ReadLine();
        Console.WriteLine("Введите Возраст");
        if (int.TryParse(Console.ReadLine(), out user1.userAge))
        {
            Console.WriteLine("Введите PIN");
            user1.userPin = Console.ReadLine();
            user1.Output();
        }
        else
        {
            Console.WriteLine("что-то пошло не так");
        }


        //3.Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
        //строчные.
        StartTask(3);
        Console.WriteLine("Введите строку, чтобы строчные буквы {0}",
            "\nбыли заменены на заглавные, заглавные – на строчные");
        string n3StringVar = Console.ReadLine();
        for (int i = 0; i < n3StringVar.Length; i++)
        {
            if (char.IsLower(n3StringVar[i]))
                Console.Write(char.ToUpper(n3StringVar[i]));
            else if (char.IsUpper(n3StringVar[i]))
                Console.Write(char.ToLower(n3StringVar[i]));
            else
                Console.Write(n3StringVar[i]);
        }
        Console.WriteLine();


        //4.Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
        //на экран.
        Console.WriteLine("Введите строку, введите подстроку, чтобы\n{0}",
            "найти количество вхождений");
        string n4String = Console.ReadLine(), n4SubString = Console.ReadLine();
        int n4Amount = 0;
        for (int i = 0; i <= n4String.Length - n4SubString.Length; i++)
        {
            bool IsSub = true;
            for (int j = 0; j < n4SubString.Length; j++)
            {
                if (n4String[i + j] != n4SubString[j])
                {
                    IsSub = false;
                    break;
                }

            }
            if (IsSub)
                n4Amount++;
        }
        Console.WriteLine(n4Amount);


        //5.Цель этой задачи -определить, сколько бутылок виски беспошлинной торговли вам
        //нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически
        //покрыла расходы на ваш отпуск. Вам будет предоставлена стандартная цена(normPrice),
        //скидка в Duty Free(salePrice) и стоимость отпуска(holidayPrice).Например, если бутылка
        //обычно стоит 10 фунтов стерлингов, а скидка в дьюти фри составляет 10 %, вы
        //сэкономите 1 фунт стерлингов на каждой бутылке.Если ваш отпуск стоит 500 фунтов
        //стерлингов, ответ, который вы должны вернуть, будет 500.Все входные данные будут
        //целыми числами.Пожалуйста, верните целое число.Округлить в меньшую сторону
        StartTask(5);
        Console.WriteLine("Укажите normPrice, salePrice(в процентах) и holidayPrice,{0}{1}",
            "\nчтобы расчитать сколько купить бутылок виски,",
            "\nдабы окупить отпуск");
        decimal normPrice, salePrice, holidayPrice;
        if (decimal.TryParse(Console.ReadLine(), out normPrice) &&
            decimal.TryParse(Console.ReadLine(), out salePrice) &&
            decimal.TryParse(Console.ReadLine(), out holidayPrice))
            Console.WriteLine((int)(holidayPrice / (normPrice / 100 * salePrice)));
        else
            Console.WriteLine("Что-то пошло не так");


        void StudentInitialization(ref Student student, string ln,
        string fn, string idNum, string bd, string ac, Drink sd, double dv)
        {
            student.lastName = ln;
            student.firstName = fn;
            student.idenityNumber = idNum;
            student.birthDate = bd;
            student.alcoholismCategory = ac;
            student.studentDrink = sd;
            student.drunkVolume = dv;
        }
        void DrinkInitialization(ref Drink drink, string dn, double ap)
        {
            drink.drinkName = dn;
            drink.alcoholPercent = ap;
        }
        void StudentOutput(Student student)
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nИдентификатор: {2}\n",
                student.lastName, student.firstName, student.idenityNumber);
            Console.WriteLine("Дата Рождения: {0}\nКатегория алкоголизма: {1}\n",
                student.birthDate, student.alcoholismCategory);
            Console.WriteLine("Обьем выпитой жидкости конкретного напитка: {0}",
                student.drunkVolume);
            Console.WriteLine("Выпито по отношению ко всем:{0}",
                student.drunkVolume / (student.overall / 100));
            Console.WriteLine("Выпито алкоголя по отношению ко всем:{0}",
                alcoholDrunk(student) / (student.overallAlcohol / 100));
        }
        double alcoholDrunk(Student student)
        {
            return student.drunkVolume / 100 * student.studentDrink.alcoholPercent;
        }
        void DrinkOutput(Drink drink)
        {
            Console.WriteLine("название:{0}\nпроцент алкоголя:{1}\n",
                drink.drinkName, drink.alcoholPercent);
        }


        //6.Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
        //рождения, Категория алкоголизма(a – студент алкоголик, b – студент любитель
        //выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
        //студента есть Объем выпитой жидкости конкретного напитка.Создать 5 студентов с
        //различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
        //(процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
        //выпил.Предполагается, что студент пьет один вид напитка. Напитки задать в виде
        //структуры: наименование типа напитка и процент спирта.
        StartTask(6);
        Console.WriteLine("Информация о студентах и как они пили");
        Console.WriteLine("Напитки");
        Drink tequila = new Drink();
        DrinkInitialization(ref tequila, "tequila", (double)50);
        DrinkOutput(tequila);
        Drink absinthe = new Drink();
        DrinkInitialization(ref absinthe, "absinthe", (double)60);
        DrinkOutput(absinthe);
        Drink vodka = new Drink();
        DrinkInitialization(ref vodka, "vodka", (double)40);
        DrinkOutput(vodka);
        Drink champagne = new Drink();
        DrinkInitialization(ref champagne, "champagne", (double)11);
        DrinkOutput(champagne);
        Drink pridoniaGarden = new Drink();
        DrinkInitialization(ref pridoniaGarden, "pridoniaGarden", (double)0);
        DrinkOutput(pridoniaGarden);
        Console.WriteLine("Пять студентов");
        Student studentIvan = new Student();
        StudentInitialization(ref studentIvan, "Тепляков", "Иван", "233132", "12.02.93", "a", tequila, 0.5);
        Student studentPetr = new Student();
        StudentInitialization(ref studentPetr, "Шолохов", "Петр", "331111", "03.11.94", "c", vodka, 1);
        Student studentVika = new Student();
        StudentInitialization(ref studentVika, "Позднякова", "Вика", "111111", "11.10.92", "a", absinthe, 0.4);
        Student studentКатя = new Student();
        StudentInitialization(ref studentКатя, "Зарипова", "Катя", "554543", "09.09.93", "b", champagne, 1);
        Student studentGeorge = new Student();
        StudentInitialization(ref studentGeorge, "Лев", "Георгий", "123121", "08.02.93", "d", pridoniaGarden, 0.7);
        double overallDrunk = studentGeorge.drunkVolume + studentIvan.drunkVolume
            + studentPetr.drunkVolume + studentVika.drunkVolume + studentКатя.drunkVolume;
        double overallAlcohol = alcoholDrunk(studentGeorge) + alcoholDrunk(studentIvan)
            + alcoholDrunk(studentPetr) + alcoholDrunk(studentVika) + alcoholDrunk(studentКатя);
        studentGeorge.overallAlcohol = overallAlcohol;
        studentGeorge.overall = overallDrunk;
        studentКатя.overallAlcohol = overallAlcohol;
        studentКатя.overall = overallDrunk;
        studentVika.overallAlcohol = overallAlcohol;
        studentVika.overall = overallDrunk;
        studentPetr.overall = overallDrunk;
        studentPetr.overallAlcohol = overallAlcohol;
        studentIvan.overall = overallDrunk;
        studentIvan.overallAlcohol = overallAlcohol;
        StudentOutput(studentIvan);
        StudentOutput(studentPetr);
        StudentOutput(studentVika);
        StudentOutput(studentКатя);
        StudentOutput(studentGeorge);
        Console.WriteLine("Общее значение");
        Console.WriteLine("Выпито всего:{0}\nВыпито алкоголя:{1}", overallDrunk, overallAlcohol);
    }
}