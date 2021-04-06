using System.Runtime.Serialization;

namespace TaskManager
{
    /// <summary>
    /// Класс типа Исполнитель.
    /// </summary>
    [DataContract]
    public class User
    {
        /// <summary>
        /// Имя исполнителя.
        /// </summary>
        [DataMember]
        public string Name { set; get; }

        /// <summary>
        /// Порядковый номер пользователя.
        /// </summary>
        [DataMember]
        public int UserID { set; get; }

        /// <summary>
        /// Конструктор с параметрами для типа Исполнитель.
        /// </summary>
        /// <param name="name"> Имя исполнителя. </param>
        public User(string name, int num)
        {
            this.Name = name;
            UserID = num;
        }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Перегрузка для вывода информации о пользователе.
        /// </summary>
        /// <returns> Имя пользователя. </returns>
        public override string ToString()
        {
            return Name;
        }
    }
}