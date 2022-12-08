namespace LB61
{
    /// <summary>
    /// Осовной код.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Главная функция.
        /// </summary>
        public static void Main()
        {
            var baggages = new List<Baggage>(10)
            {
                new Baggage
                {
                    Name = "Иванов И.И.",
                    Weight = 40,
                    Count = 2
                },
                new Baggage
                {
                    Name = "Петров П.П.",
                    Weight = 35.5F,
                    Count = 1
                },
                new Baggage
                {
                    Name = "Матвеев И.Р.",
                    Weight = 12,
                    Count = 2
                },
                new Baggage
                {
                    Name = "Сидоров С.С.",
                    Weight = 15.4F,
                    Count = 1
                },
                new Baggage
                {
                    Name = "Ромин Р.Р.",
                    Weight = 10,
                    Count = 1
                },
                new Baggage
                {
                    Name = "Измайлов И.И.",
                    Weight = 50,
                    Count = 1
                },
                new Baggage
                {
                    Name = "Питонов И.Р.",
                    Weight = 31,
                    Count = 2
                },
                new Baggage
                {
                    Name = "Яковлев П.О.",
                    Weight = 19.7F,
                    Count = 1
                },
                new Baggage
                {
                    Name = "Миронов В.В.",
                    Weight = 23.6F,
                    Count = 3
                },
                new Baggage
                {
                    Name = "Сергеев С.С.",
                    Weight = 36.5F,
                    Count = 4
                }
            };

            foreach (Baggage i in baggages)
            {
                Console.WriteLine(i.Print());
            }

            // количество вещей в списке
            var count_v = 0;

            // вес всех вещей в списке
            double weight_v = 0;

            foreach (Baggage i in baggages)
            {
                count_v += i.Count;
                weight_v += i.Weight;
            }

            // Обший средний вес одной вещи по всему списку
            var average_v = weight_v / count_v;
            Console.WriteLine("\nОбший средний вес одной вещи по всему " +
                "списку {0}", average_v);
            Console.WriteLine("\nПассажиры удовлетворяющие условию: ");

            foreach (Baggage i in baggages)
            {
                if (Math.Abs((i.Weight / i.Count) - average_v) <= 0.3)
                {
                    Console.WriteLine(i.Print());
                }

            }

        }
    }
}
