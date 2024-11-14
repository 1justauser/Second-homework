using System.Text;
using System.Threading.Channels;

public struct UserInfo()
{
    /// <summary>
    /// Имя Пользователя
    /// </summary>
    public string userName;


    /// <summary>
    /// Город Пользователя
    /// </summary>
    public string userPlace;


    /// <summary>
    /// Возраст Пользователя
    /// </summary>
    public int userAge;


    /// <summary>
    /// ПинКод Пользователя
    /// </summary>
    public string userPin;


    ///<summary>
    ///Вывод Информации о Пользователе
    ///</summary>
    public void Output()
    {
        Console.WriteLine("Имя пользователя:{0}\nГород пользователя:{1}", userName, userPlace);
        Console.WriteLine("Возраст пользователя:{0}\nPIN-код пользователя:{1}", userAge, userPin);
    }

}
public struct Student
{
    /// <summary>
    /// Фамилия Студента
    /// </summary>
    public string lastName;
    
    
    /// <summary>
    /// Имя Студента
    /// </summary>
    public string firstName;


    /// <summary>
    /// Идентификационный Номер Студента
    /// </summary>
    public string idenityNumber;

    
    /// <summary>
    /// Дата Рождения Студента
    /// </summary>
    public string birthDate;
    /// <summary>
    /// Категория Алкоголизма Студента
    /// </summary>
    public string alcoholismCategory;


    /// <summary>
    /// Напиток Студента
    /// </summary>
    public Drink studentDrink;


    /// <summary>
    /// Количество Выпитой Жидкости Студента
    /// </summary>
    public double drunkVolume;


    /// <summary>
    /// Количество Жидкости Выпитой Всеми
    /// </summary>
    public double overallVolume;


    /// <summary>
    /// Количество Алкоголя Выпитого Всеми
    /// </summary>
    public double overallAlcoholVolume;


    /// <summary>
    /// Инициализация Студента
    /// </summary>
    /// <param name="ln"></param>
    /// <param name="fn"></param>
    /// <param name="idNum"></param>
    /// <param name="bd"></param>
    /// <param name="ac"></param>
    /// <param name="sd"></param>
    /// <param name="dv"></param>
    public void StudentInitialization(string ln,
        string fn, string idNum, string bd, string ac, Drink sd, double dv)
    {
        lastName = ln;
        firstName = fn;
        idenityNumber = idNum;
        birthDate = bd;
        alcoholismCategory = ac;
        studentDrink = sd;
        drunkVolume = dv;
    }


    /// <summary>
    /// Вывод Информации о Студенте
    /// </summary>
    public void StudentOutput()
    {
        Console.WriteLine("Фамилия: {0}\nИмя: {1}\nИдентификатор: {2}",
            lastName, firstName, idenityNumber);
        Console.WriteLine("Дата Рождения: {0}\nКатегория алкоголизма: {1}",
            birthDate, alcoholismCategory);
        Console.WriteLine("Обьем выпитой жидкости конкретного напитка: {0}\n\n",
            drunkVolume);
    }


    /// <summary>
    /// Обьем Выпитого Алкоголя Студентом
    /// </summary>
    /// <returns></returns>
    public double alcoholVolume()
    {
        return drunkVolume / 100 * studentDrink.alcoholPercent;
    }


    /// <summary>
    /// Соотношения Выпитой Жидкости и Алкоголя Студентом к Жидкости и Алкоголя Выпитых Всеми 
    /// </summary>
    public void StudentVolumeRatioToOverallVolume()
    {
        Console.WriteLine($"Для Студента {lastName} {firstName}:\n");
        if (Math.Round(drunkVolume / (overallVolume / 100), 2) == 0)
            Console.WriteLine("Выпито жидкости по отношению ко всем:{0}",
                Math.Round(drunkVolume / (overallVolume / 100), 2));
        else
            Console.WriteLine("Выпито жидкости по отношению ко всем:{0}%",
                Math.Round(drunkVolume / (overallVolume / 100), 2));
        if(Math.Round(alcoholVolume() / (overallAlcoholVolume / 100), 2)==0)
            Console.WriteLine("Выпито алкоголя по отношению ко всем:{0}\n\n",
                Math.Round(alcoholVolume() / (overallAlcoholVolume / 100), 2));
        else 
            Console.WriteLine("Выпито алкоголя по отношению ко всем:{0}%\n\n",
                Math.Round(alcoholVolume() / (overallAlcoholVolume / 100), 2));
    }
}


public struct Drink
{
    /// <summary>
    /// Название Напитка
    /// </summary>
    public string drinkName;


    /// <summary>
    /// Процент Алкоголя Напиток
    /// </summary>
    public double alcoholPercent;


    /// <summary>
    /// Ининциализация Напитка
    /// </summary>
    /// <param name="dn"></param>
    /// <param name="ap"></param>
    public void DrinkInitialization(string dn, double ap)
    {
        drinkName = dn;
        alcoholPercent = ap;
    }


    /// <summary>
    /// Вывод Информации о Напитке
    /// </summary>
    public void DrinkOutput()
    {
        Console.WriteLine("название:{0}\nпроцент алкоголя:{1}\n\n",
            drinkName, alcoholPercent);
    }
}


public class Tasks
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;


        void StartTask(int n)
        {
            Console.WriteLine("\n\nЗадание {0}", n);
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


        //2.Напишите программу, в которой принимаются данные пользователя в виде имени,
        //города, возраста и PIN-кода.Далее сохраните все значение в соответствующей
        //переменной, а затем распечатайте всю информацию в правильном формате.
        StartTask(2);
        UserInfo user = new UserInfo();
        bool somethingIsWrong = false;
        Console.WriteLine("Принимаются данные пользователя в виде имени,");
        Console.WriteLine("города, возраста и PIN-кода\n\n");
        Console.WriteLine("Введите имя");
        user.userName = Console.ReadLine();
        if (string.IsNullOrEmpty(user.userName))
        {
            somethingIsWrong = true;
            Console.WriteLine("Имя должно быть указано!");
        }
        else
        {
            for (int i = 0; i < user.userName.Length; i++)
            {
                if (!char.IsLetter(user.userName[i]) && user.userName[i] != '-')
                {
                    Console.WriteLine("Имя состоит только из букв или знака \"-\"!");
                    somethingIsWrong = true;
                    break;
                }
            }
        }
        if (somethingIsWrong)
            Console.WriteLine("");
        else
        {
            Console.WriteLine("Введите Город");
            user.userPlace = Console.ReadLine();
            if (string.IsNullOrEmpty(user.userPlace))
            {
                somethingIsWrong = true;
                Console.WriteLine("Город должен быть указан!");
            }
            else
            {
                for (int i = 0; i < user.userPlace.Length; i++)
                {
                    if (!char.IsLetter(user.userPlace[i]) && user.userPlace[i] != '-')
                    {
                        Console.WriteLine("Имя Состоит только из букв или знака \"-\"");
                        somethingIsWrong = true;
                        break;
                    }
                }
            }
        }
        if (!somethingIsWrong)
        {
            Console.WriteLine("Введите Возраст");
            if (!int.TryParse(Console.ReadLine(), out user.userAge))
            {
                Console.WriteLine("Должно быть число!");
                somethingIsWrong = true;
            }
            else if (user.userAge <= 0 || user.userAge > 150)
            {
                Console.WriteLine("Возраст должен быть от 1 до 150 включительно");
                somethingIsWrong = true;
            }
        }
        if (!somethingIsWrong)
        {
            Console.WriteLine("Введите Пинкод");
            user.userPin = Console.ReadLine();
            for (int i = 0; i < user.userPin.Length; i++)
            {
                if (user.userPin[i] != ' ')
                {
                    if (user.userPin.Length - i < 6)
                    {
                        Console.WriteLine("Слишком короткий ПинКод");
                        somethingIsWrong = true;
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (!((int)user.userPin[i + j] <= (int)'9'
                                && (int)user.userPin[i + j] >= (int)'0'))
                            {
                                Console.WriteLine("ПинКод состоит только из цифр и имеет длину ровно 6!");
                                somethingIsWrong = true;
                                break;
                            }
                        }
                        for (int j = 7; i + j < user.userPin.Length && !somethingIsWrong; j++)
                        {
                            if (user.userPin[i + j] != ' ')
                            {
                                Console.WriteLine("ПинКод состоит только из цифр и имеет длину ровно 6!");
                                somethingIsWrong = true;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }
        if (somethingIsWrong)
            Console.WriteLine("\nПроизошла ошибка, попробуйте ещё раз");
        else
        {
            Console.WriteLine("\n");
            user.Output();
        }


        //3.Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
        //строчные.
        StartTask(3);
        Console.WriteLine("Введите строку, чтобы строчные буквы {0}",
            "\nбыли заменены на заглавные, заглавные – на строчные");
        string StringVar = Console.ReadLine();
        for (int i = 0; i < StringVar.Length; i++)
        {
            if (char.IsLower(StringVar[i]))
                Console.Write(char.ToUpper(StringVar[i]));
            else if (char.IsUpper(StringVar[i]))
                Console.Write(char.ToLower(StringVar[i]));
            else
                Console.Write(StringVar[i]);
        }
        Console.WriteLine();


        //4.Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести
        //на экран.
        Console.WriteLine("Введите строку, введите подстроку, чтобы\n{0}",
            "найти количество вхождений");
        string mainString = Console.ReadLine(), subString = Console.ReadLine();
        int amount = 0;
        for (int i = 0; i <= mainString.Length - subString.Length; i++)
        {
            bool IsSub = true;
            for (int j = 0; j < subString.Length; j++)
            {
                if (mainString[i + j] != subString[j])
                {
                    IsSub = false;
                    break;
                }

            }
            if (IsSub)
                amount++;
        }
        Console.WriteLine(amount);


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


        //6.Создать структуру студента. У студента есть Фамилия, Имя, его Идентификатор, Дата
        //рождения, Категория алкоголизма(a – студент алкоголик, b – студент любитель
        //выпить, но не алкоголик, c – студент пьет по праздникам, d – студент не пьет), также у
        //студента есть Объем выпитой жидкости конкретного напитка.Создать 5 студентов с
        //различными параметрами. Посчитать общий объем выпитого, общий объем алкоголя
        //(процент спирта) и кто сколько процентов алкоголя и жидкости от общего количества
        //выпил.Предполагается, что студент пьет один вид напитка. Напитки задать в виде
        //структуры: наименование типа напитка и процент спирта.
        StartTask(6);

        Console.WriteLine("Информация о напитках");


        Drink tequila = new Drink();
        tequila.DrinkInitialization("tequila", (double)50);
        tequila.DrinkOutput();


        Drink absinthe = new Drink();
        absinthe.DrinkInitialization("absinthe", (double)60);
        absinthe.DrinkOutput();


        Drink vodka = new Drink();
        vodka.DrinkInitialization("vodka", (double)40);
        vodka.DrinkOutput();


        Drink champagne = new Drink();
        champagne.DrinkInitialization("champagne", (double)11);
        champagne.DrinkOutput();


        Drink pridoniaGarden = new Drink();
        pridoniaGarden.DrinkInitialization("pridoniaGarden", (double)0);
        pridoniaGarden.DrinkOutput();


        Console.WriteLine("Информация о пяти студентах и как они пили");


        Student studentIvan = new Student();
        studentIvan.StudentInitialization("Тепляков", "Иван", "233132", "12.02.93", "a", tequila, 0.5);
        studentIvan.StudentOutput();


        Student studentPetr = new Student();
        studentPetr.StudentInitialization("Шолохов", "Петр", "331111", "03.11.94", "c", vodka, 1);
        studentPetr.StudentOutput();


        Student studentVika = new Student();
        studentVika.StudentInitialization("Позднякова", "Вика", "111111", "11.10.92", "a", absinthe, 0.4);
        studentVika.StudentOutput();


        Student studentКатя = new Student();
        studentКатя.StudentInitialization("Зарипова", "Катя", "554543", "09.09.93", "b", champagne, 1);
        studentКатя.StudentOutput();


        Student studentGeorge = new Student();
        studentGeorge.StudentInitialization("Лев", "Георгий", "123121", "08.02.93", "d", pridoniaGarden, 0.7);
        studentGeorge.StudentOutput();

        double overallVolume = studentGeorge.drunkVolume + studentIvan.drunkVolume
            + studentPetr.drunkVolume + studentVika.drunkVolume + studentКатя.drunkVolume;
        double overallAlcoholVolume = studentGeorge.alcoholVolume() + studentIvan.alcoholVolume()
            + studentPetr.alcoholVolume() + studentVika.alcoholVolume() + studentКатя.alcoholVolume();
        studentGeorge.overallAlcoholVolume = overallAlcoholVolume;
        studentGeorge.overallVolume = overallVolume;
        studentКатя.overallAlcoholVolume = overallAlcoholVolume;
        studentКатя.overallVolume = overallVolume;
        studentVika.overallAlcoholVolume = overallAlcoholVolume;
        studentVika.overallVolume = overallVolume;
        studentPetr.overallVolume = overallVolume;
        studentPetr.overallAlcoholVolume = overallAlcoholVolume;
        studentIvan.overallVolume = overallVolume;
        studentIvan.overallAlcoholVolume = overallAlcoholVolume;


        Console.WriteLine("Общее значение");
        if(Math.Round(overallAlcoholVolume / (overallVolume / 100), 2) == 0)
            Console.WriteLine("Выпито жидкости : {0}\nВыпито алкоголя : {1}\nПроцент спирта : {2}\n\n",
            overallVolume, overallAlcoholVolume, Math.Round(overallAlcoholVolume / (overallVolume / 100), 2));
        else
            Console.WriteLine("Выпито жидкости : {0}\nВыпито алкоголя : {1}\nПроцент спирта : {2}%\n\n",
            overallVolume, overallAlcoholVolume, Math.Round(overallAlcoholVolume / (overallVolume / 100), 2));

        studentIvan.StudentVolumeRatioToOverallVolume();
        studentPetr.StudentVolumeRatioToOverallVolume();
        studentVika.StudentVolumeRatioToOverallVolume();
        studentКатя.StudentVolumeRatioToOverallVolume();
        studentGeorge.StudentVolumeRatioToOverallVolume();
    }
}
