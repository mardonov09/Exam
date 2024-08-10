using Microsoft.VisualBasic;

namespace MyClasses;
public enum TransactionType
{
  Purchase,
  Return,
}
public class Transaction
{
  public int Id { get; set; }
  public DateTime Date { get; set; }
  public decimal Amount { get; set; }

  public Transaction(int id, DateTime date, decimal amount)
  {
    Id = id;
    Date = date;
    Amount = amount;
  }
}

public class TransactionManager<T> where T : Transaction
{
  public List<T> transactions = new List<T>();

  public void AddTransaction(T transac)
  {
    transactions.Add(transac);
  }
  public void RemoveTransaction(T transac)
  {
    transactions.Remove(transac);
  }
  public List<T> GetAllTransactions()
  {
    return transactions;
  }
  public Transaction GetAllTransacForOneYear(DateTime dateTime)
  {
    var result = transactions.Find(x => x.Date.Year == dateTime.Year);
    if (result == null)
    {
      System.Console.WriteLine("Транзакции нет");
    }
    return result;
  }
}
// Реализуйте систему истории транзакций для магазина.

// Каждая `Transaction` должна включать:

// - Id - `int`
// - Date - `DateTime `
// - Amount - `decimal`
// - TransactionType - `enum` (`Purchase`, `Return` и другие)

// `TransactionManager`: класс для управления транзакциями с методами добавления, поиска и расчета общего объема продаж.

// Используйте `List<Transaction>` для хранения транзакций и реализации методов:

// - Добавление новых транзакций.
// - Получить все транзакции за один определенный год.
// - Расчет общего объема продаж за определенный период.
// - Поиск первой и последней транзакции.