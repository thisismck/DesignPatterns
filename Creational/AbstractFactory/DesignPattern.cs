using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /*
     * Bir uygulama ADO.NET ile db ile konuşmaktadır. DB sağlayıcısı oracle ve sql server olmak üzere 
     * iki farklı db sağlayıcısı olabilir.
     * Bu durumda hangi nesneler ile çalışacağımızı belirtmeden doğru business nesnelerini nasıl üretiriz?
     * 
     */

    public interface IConnection
    {
        void Open();
        void Close();
    }
    public interface ICommand
    {
        void Execute();
    }

    // 2. Elementleri somutlaştırıyoruz.

    public class MssqlConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("Sql Connection Opened");
        }
        public void Close()
        {
            Console.WriteLine("Sql Connection Closed");
        }
    }

    public class MssqlCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Sql Command Executed");
        }
    }

    public class OracleConnection : IConnection
    {
        public void Open()
        {
            Console.WriteLine("Oracle Connection Opened");
        }
        public void Close()
        {
            Console.WriteLine("Oracle Connection Closed");
        }
    }

    public class OracleCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Oracle Command Executed");
        }
    }

    // 3. Abstract Factory

    public interface IDatabaseFactory
    {
        IConnection CreateConnection();
        ICommand CreateCommand();
    }

    // 4. Concrete Factory

    public class MssqlFactory : IDatabaseFactory
    {
        public IConnection CreateConnection()
        {
            return new MssqlConnection();
        }
        public ICommand CreateCommand()
        {
            return new MssqlCommand();
        }
    }

    public class OracleFactory : IDatabaseFactory
    {
        public IConnection CreateConnection()
        {
            return new OracleConnection();
        }
        public ICommand CreateCommand()
        {
            return new OracleCommand();
        }
    }

    // 5. Client Generic

    public class DbFactoryCreator<T> where T : IDatabaseFactory, new()
    {
        public static IDatabaseFactory CreateFactory()
        {
            return new T();
        }
    }

    public class DatabaseManager
    {
        private IDatabaseFactory _databaseFactory;
        private IConnection _connection;
        private ICommand _command;

        public DatabaseManager(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Save()
        {
            _connection.Open();
            _command.Execute();
            _connection.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager databaseManager = new DatabaseManager(new MssqlFactory());
            databaseManager.Save();
        }
    }

}
