namespace LB61
{
    /// <summary>
    /// Метод описывает багаж пассажира.
    /// </summary>
    public struct Baggage
    {
        /// <summary>
        /// Gets or sets имя человека.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets количество багажа.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets вес багажа.
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Выводит в консоль.
        /// </summary>
        /// <returns> Вывод строки.</returns>
        public string Print()
        {
            return $"Имя: {Name}, Количество вещей: {Count}" +
                   $", Вес багажа: {Weight} кг";
        }
    }
}

