using System.Text;
public struct Bank1Account
{
    public decimal Savings;
    public decimal Current;
    public void Output()
    {
        Console.WriteLine("текущий счет: {0}\nсберегательный счет: {1}", Current, Savings);
    }
}
public struct Bank2Account
{
    public int accountNumber;
    public string accountType;
    public decimal accountBalance;
    public void Output() { 
        Console.WriteLine("номер счета:{0}\nтип счета:{1}\nбаланс счета:{2}",
        accountNumber, accountType,accountBalance); 
    }
}
public enum ВУЗ
{
    КГУ,КАИ,КХТИ
}
public struct UniverstityWorker
{
    public string firstName;
    public ВУЗ universtity;
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
        Bank1Account bank1Account = new Bank1Account();
        bank1Account.Current = 133.22m;
        bank1Account.Savings = 333333.11m;
        bank1Account.Output();
        //Упражнение 3.2 Создать структуру данных, которая хранит информацию
        //о банковском счете – его номер, тип и баланс. Создать переменную такого типа,
        //заполнить структуру значениями и напечатать результат.
        Console.WriteLine("Упражнение 3.2");
        Bank2Account bank2Account = new Bank2Account();
        bank2Account.accountNumber = 2230011;
        bank2Account.accountType = "saving";
        bank2Account.accountBalance = 133.12m;
        bank2Account.Output();
        //Домашнее задание 3.1 Создать перечислимый тип ВУЗ{КГУ, КАИ,
        //КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ. Заполнить
        //структуру данными и распечатать.  
        Console.WriteLine("Домашнее задание 3.1");
        UniverstityWorker Андрей = new UniverstityWorker();
        Андрей.firstName = "Андрей";
        Андрей.universtity = ВУЗ.КАИ;
        Андрей.Output();
    }
}