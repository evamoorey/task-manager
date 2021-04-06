using System;
using System.Collections.Generic;

namespace TaskManager
{
    /// <summary>
    /// Интерфейс для работы со списком пользователей.
    /// </summary>
    public interface IAssignable
    {
        /// <summary>
        /// Лист пользователей.
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// Максимальное количество пользователей.
        /// </summary>
        public int MaxCount { set; get; }

        /// <summary>
        /// Добавление пользователя в список.
        /// </summary>
        /// <param name="item"> Новый пользователь. </param>
        void Add(User item)
        {
            if (Users.Count <= MaxCount)
                Users.Add(item);
            else
                throw new ArgumentException("Too many users.");
        }

        /// <summary>
        /// Удаление пользователя из списка.
        /// </summary>
        /// <param name="item"> Пользователь для удаления. </param>
        /// <returns> Был ли удален пользователь. </returns>
        bool Remove(User item)
        {
            return Users.Remove(item);
        }

        /// <summary>
        /// Удаление пользователя из списка по индексу.
        /// </summary>
        /// <param name="i"> Индекс пользователя. </param>
        void RemoveIndex(int i)
        {
            Users.RemoveAt(i);
        }

        /// <summary>
        /// Смена пользователя.
        /// </summary>
        /// <param name="item"> Новый пользователь. </param>
        /// <param name="item2"> Старый пользователь. </param>
        void Swap(User item, User item2)
        {
            Users[Users.IndexOf(item2)] = item;
        }
    }
}