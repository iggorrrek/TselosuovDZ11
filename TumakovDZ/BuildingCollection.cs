using System;


namespace TumakovDZ
{
    class BuildingCollection
    {
        private Building[] buildings = new Building[10]; 

        public Building this[int index]
        {
            get
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона массива");
                }
                return buildings[index];
            }
            set
            {
                if (index < 0 || index >= buildings.Length)
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона массива");
                }
                buildings[index] = value;
            }
        }
    }
}
