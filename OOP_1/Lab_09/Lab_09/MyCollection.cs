using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09
{
    //словарь
    public class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        //определяет коллекцию
        private Dictionary<TKey, TValue> innerDictionary = new Dictionary<TKey, TValue>();
        //для хранения идентификатора
        public static int id { get; set; }
        //позволяет обращаться к элементам коллекции по ключу
        public TValue this[TKey key]
        {
            get
            {
                if (innerDictionary.ContainsKey(key))
                {
                    return innerDictionary[key];
                }
                throw new KeyNotFoundException();
            }
            set
            {
                innerDictionary[key] = value;
            }
        }
        //возвращает кол-во эл-тов
        public int Count => innerDictionary.Count;

        public bool IsReadOnly => ((IDictionary<TKey, TValue>)innerDictionary).IsReadOnly;

        public ICollection<TKey> Keys => innerDictionary.Keys;

        public ICollection<TValue> Values => innerDictionary.Values;
        //Добавляет элемент с указанным ключом 
        public void Add(TKey key, TValue value)
        {
            innerDictionary.Add(key, value);
        }
        //Добавляет элемент типа 
        public void Add(KeyValuePair<TKey, TValue> item)
        {
            ((IDictionary<TKey, TValue>)innerDictionary).Add(item);
        }
        //Выводит на консоль все пары
        public void Print()
        {
            foreach (var item in innerDictionary)
            {
                Console.WriteLine($"Ключ: {item.Key}, {item.Value}");
            }
        }
        // Очищает коллекцию
        public void Clear()
        {
            innerDictionary.Clear();
            id = 0;
        }
        //содержится ли указанный ключ
        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return ((IDictionary<TKey, TValue>)innerDictionary).Contains(item);
        }

        public bool ContainsKey(TKey key)
        {
            return innerDictionary.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ((IDictionary<TKey, TValue>)innerDictionary).CopyTo(array, arrayIndex);
        }
        //Интерфейс, который предоставляет методы для перебора элементов в коллекции.
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return innerDictionary.GetEnumerator();
        }
        //Удаляет элемент
        public bool Remove(TKey key)
        {
            return innerDictionary.Remove(key);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return ((IDictionary<TKey, TValue>)innerDictionary).Remove(item);
        }
        //реализует интерфейс IDictionary
        public bool TryGetValue(TKey key, out TValue value)
        {
            return innerDictionary.TryGetValue(key, out value);
        }
        //позволяет коллекции быть перечисляемой
        //реализует интерфейс IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
