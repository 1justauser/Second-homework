using System.Text;
public struct FirstBankAccount
{
    /// <summary>
    /// Сбережения Банковского Счета
    /// </summary>
    public decimal Savings;


    /// <summary>
    /// Текущий Счет Банковского Счета
    /// </summary>
    public decimal Current;


    /// <summary>
    /// Вывод Информации о Банковском Счета
    /// </summary>
    public void Output()
    {
        Console.WriteLine("текущий счет: {0}\nсберегательный счет: {1}", Current, Savings);
    }
}
public struct SecondBankAccount
{
    /// <summary>
    /// Номер Банкоского Счета
    /// </summary>
    public int accountNumber;


    /// <summary>
    /// Тип Банковского Счета
    /// </summary>
    public string accountType;

    /// <summary>
    /// Баланс Банковского Счета
    /// </summary>
    public decimal accountBalance;


    /// <summary>
    /// Вывод Информации о Банковском Счете
    /// </summary>
    public void Output()
    {
        Console.WriteLine("номер счета:{0}\nтип счета:{1}\nбаланс счета:{2}",
        accountNumber, accountType, accountBalance);
    }
}
public enum ВУЗ
{
    КГУ, КАИ, КХТИ
}
public struct UniverstityWorker
{
    /// <summary>
    /// Имя Работника Университета
    /// </summary>
    public string firstName;


    /// <summary>
    /// Название Университета
    /// </summary>
    public ВУЗ universtity;


    /// <summary>
    /// Вывод Информации о Работнике Университета
    /// </summary>
    public void Output()
    {
        Console.WriteLine("Имя:{0}\nВУЗ:{1}", firstName, universtity);
    }
}
public class Tumakov
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;


        void StartTask(int n)
        {
            Console.WriteLine("Задание {0}", n);
        }


        //Упражнение 3.1 Создать перечислимый тип данных отображающий
        //виды банковского счета(текущий и сберегательный). Создать переменную типа
        //перечисления, присвоить ей значение и вывести это значение на печать.
        Console.WriteLine("Упражнение 3.1");
        Console.WriteLine("Перечислимый тип данных отображающий виды банковского счета");
        FirstBankAccount bank1Account = new FirstBankAccount();
        bank1Account.Current = 133.22m;
        bank1Account.Savings = 333333.11m;
        bank1Account.Output();


        //Упражнение 3.2 Создать структуру данных, которая хранит информацию
        //о банковском счете – его номер, тип и баланс. Создать переменную такого типа,
        //заполнить структуру значениями и напечатать результат.
        Console.WriteLine("\n\nУпражнение 3.2");
        Console.WriteLine("Структура данных, которая хранит информацию\n{0}",
            "о его банковском счете - его номер тип и баланс.");
        SecondBankAccount bank2Account = new SecondBankAccount();
        bank2Account.accountNumber = 2230011;
        bank2Account.accountType = "saving";
        bank2Account.accountBalance = 133.12m;
        bank2Account.Output();


        //Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ,
        //КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить
        //структуру данными и распечатать.  
        Console.WriteLine("\n\nДомашнее задание 3.1");
        Console.WriteLine("Структура работник с двумя полями: имя, ВУЗ");
        UniverstityWorker Андрей = new UniverstityWorker();
        Андрей.firstName = "Андрей";
        Андрей.universtity = ВУЗ.КАИ;
        Андрей.Output();
    }
}
