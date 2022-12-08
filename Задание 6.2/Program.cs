namespace LB62
{
    /// <summary>
    /// Программа.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Добавление нового самолёта.
        /// </summary>
        /// <param name="planes">.</param>
        public void AddPlane(List<Aeroflot> planes)
        {
            Console.Write("Введите номер нового самолёта: ");
            ushort number;

            // Равносильно "пока не true"
            while (!ushort.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введён некорректный номер, повторите ввод!");
            }

            Console.Write("Введите тип самолёта: ");
            var type1 = Console.ReadLine();

            Console.Write("Введите место назначения: ");
            var place = Console.ReadLine();
            planes.Add(new Aeroflot(place, number, type1));
        }

        /// <summary>
        /// Сохранение.
        /// </summary>
        /// <param name="planes"> Список структур. </param>
        public void Save(List<Aeroflot> planes)
        {
            Console.Write("Введите название файла в который необходимо" +
            " сохранить данные: ");
            var nameFile = "D:\\С#\\" + Console.ReadLine() + ".txt";
            using (StreamWriter sw = new StreamWriter(nameFile, false))
            {
                planes.ForEach((t) => sw.WriteLine(t.ToString()));
            }
        }

        /// <summary>
        /// Чтение и печать в txt.
        /// </summary>
        public void ReadAndPrint()
        {
            Console.Write("Введите название файла из которого читать данные: ");
            string nameFile = "D:\\С#\\" + Console.ReadLine() + ".txt";
            using (StreamReader sr = new StreamReader(nameFile))
            {
                string text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
        }

        /// <summary>
        /// Ввод типа самолёта.
        /// </summary>
        /// <param name="planes">.</param>
        /// <returns>.</returns>
        public List<Aeroflot> ViborkaAndSort(ref List<Aeroflot> planes)
        {
            Console.Write("Введите тип самолёта: ");
            string type1 = Console.ReadLine();
            List<Aeroflot> subList = planes.Where((t) => t.PlaneType == type1).ToList();

            // Сортировка по пункту назначения
            subList.Sort((x, y) => x.Destination.CompareTo(y.Destination));

            if (subList.Capacity == 0)
            {
                Console.WriteLine($"Самолётов типа {type1} нет в аэропорту.");
            }
            else
            {
                Console.WriteLine($"Список самолётов типа {type1}: ");
                subList.ForEach((t) => Console.WriteLine(t.ToString()));
            }

            return subList;
        }

        /// <summary>
        /// Сохранение списка в XML.
        /// </summary>
        /// <param name="planes"> список.</param>
        public void SaveXml(ref List<Aeroflot> planes)
        {
            Console.Write("Введите название файла xml в который необходимо сохранить данные: ");
            string nameFile = "D:\\С#\\" + Console.ReadLine() + ".xml";

            using (StreamWriter xm = new StreamWriter(nameFile, false))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Aeroflot>));
                xmlSerializer.Serialize(xm, planes);
            }
        }

        /// <summary>
        /// Загрузка из xml-файла.
        /// </summary>
        /// <param name="xmlPlanes">файл.</param>
        public void LoadXml(ref List<Aeroflot> xmlPlanes)
        {
            Console.Write("Введите название файла xml из которого читать данные: ");
            string nameFile = "D:\\С#\\" + Console.ReadLine() + ".xml";
            using (StreamReader xm = new StreamReader(nameFile))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Aeroflot>));
                xmlPlanes = (List<Aeroflot>)xmlSerializer.Deserialize(xm);
            }
        }
    }
}
