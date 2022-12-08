namespace LB62
{
    /// <summary>
    /// Main program.
    /// </summary>
    internal class Main_program
    {
        /// <summary>
        /// Main.
        /// </summary>
        public static void Main()
        {
            List<Aeroflot> planes = new List<Aeroflot>(3);
            Program pr = new Program();

            // Создание исхдного списка
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Заполнение самолёта № {i}");
                pr.AddPlane(planes);
            }

            // Сохранение списка в txt файл
            pr.Save(planes);

            // Чтение из txt файла и вывод в консоль
            pr.ReadAndPrint();

            // Создание выборки и вывод в консоль
            List<Aeroflot> subList1 = pr.ViborkaAndSort(ref planes);

            // Сохранение выборки в txt файл
            pr.Save(subList1);
            /*
            // Ниже часть для ЛБ 6_3
            // Сохранение в XML файл исходного списка
            pr.SaveXml(ref planes);

            // Чтение из xml
            List<Aeroflot> xmlPLanes = new List<Aeroflot>();
            pr.LoadXml(ref xmlPLanes);

            List<Aeroflot> sortXmlTrains = pr.ViborkaAndSort(ref xmlPLanes);

            // Сохранение списка
            pr.Save(sortXmlTrains);
            */
        }

    }
}
