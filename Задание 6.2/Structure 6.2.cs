namespace LB62
{
    public struct Aeroflot
    {
        private string _plase;
        private ushort _number;
        private string _type;

        /// <summary>
        /// Gets or sets время прибытия.
        /// </summary>
        public string PlaneType
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        /// <summary>
        /// Gets or sets место.
        /// </summary>
        public string Destination
        {
            get
            {
                return _plase;
            }

            set
            {
                _plase = value;
            }
        }

        /// <summary>
        /// Gets or sets номер поезда.
        /// </summary>
        public ushort PlaneNumber
        {
            get
            {
                return _number;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Задан пустой номер самолёта");
                }

                _number = value;
            }
        }

        /// <summary>
        /// Печать.
        /// </summary>
        /// <returns> Строку.</returns>
        public override string ToString()
        {
            return $"Номер самолёта: {PlaneNumber}, тип самолёта: {PlaneType}, пункт назначения: {Destination}";
        }

        public Aeroflot(string place, ushort number, string type)
        {
            _plase = place;
            _number = number;
            _type = type;
        }
    }
}
