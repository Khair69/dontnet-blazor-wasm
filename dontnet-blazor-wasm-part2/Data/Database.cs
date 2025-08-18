using dontnet_blazor_wasm_part2.Models;

namespace dontnet_blazor_wasm_part2.Data
{
    public class Database
    {
        public List<Manufacture> Companies { get; set; } = new List<Manufacture>();
        public List<Car> Cars { get; set; } = new List<Car>();

        public Database()
        {
            Companies.Add(new Manufacture
            {
                ManufactureId = 1,
                Name = "Mitsubishi"
            });
            Companies.Add(new Manufacture
            {
                ManufactureId = 2,
                Name = "Ferrari"
            });
            Companies.Add(new Manufacture
            {
                ManufactureId = 3,
                Name = "Ford"
            });
            Companies.Add(new Manufacture
            {
                ManufactureId = 4,
                Name = "Nissas"
            });
            Companies.Add(new Manufacture
            {
                ManufactureId = 5,
                Name = "Lamborghini"
            });
            Companies.Add(new Manufacture
            {
                ManufactureId = 6,
                Name = "Koenigsegg"
            });
            Companies.Add(new Manufacture
            {
                ManufactureId = 7,
                Name = "Audi"
            });
            Companies.Add(new Manufacture
            {
                ManufactureId = 8,
                Name = "Porsche"
            });

            //Mitsubishi
            Cars.Add(new Car
            {
                CarId = 1,
                ManufactureId = 1,
                Name = "Lancer Evolution X"
            });
            Cars.Add(new Car
            {
                CarId = 2,
                ManufactureId = 1,
                Name = "Lancer Evolution VI"
            });

            //Ferrari
            Cars.Add(new Car
            {
                CarId = 3,
                ManufactureId = 2,
                Name = "F40"
            });
            Cars.Add(new Car
            {
                CarId = 4,
                ManufactureId = 2,
                Name = "Testarossa"
            });
            Cars.Add(new Car
            {
                CarId = 5,
                ManufactureId = 2,
                Name = "458 Spider"
            });
            Cars.Add(new Car
            {
                CarId = 6,
                ManufactureId = 2,
                Name = "599 GTO"
            });

            //Ford
            Cars.Add(new Car
            {
                CarId = 7,
                ManufactureId = 3,
                Name = "Focus RS"
            });
            Cars.Add(new Car
            {
                CarId = 8,
                ManufactureId = 3,
                Name = "Shelby GT500"
            });
            Cars.Add(new Car
            {
                CarId = 9,
                ManufactureId = 3,
                Name = "Musang GT Premium"
            });
            Cars.Add(new Car
            {
                CarId = 10,
                ManufactureId = 3,
                Name = "GT (2005)"
            });

            //Nissan
            Cars.Add(new Car
            {
                CarId = 11,
                ManufactureId = 4,
                Name = "Silvia"
            });
            Cars.Add(new Car
            {
                CarId = 12,
                ManufactureId = 4,
                Name = "Skyline GT-R V-SPEC R34"
            });
            Cars.Add(new Car
            {
                CarId = 13,
                ManufactureId = 4,
                Name = "370Z"
            });
            Cars.Add(new Car
            {
                CarId = 14,
                ManufactureId = 4,
                Name = "GT-R Premium R35"
            });

            //Lamborghini
            Cars.Add(new Car
            {
                CarId = 15,
                ManufactureId = 5,
                Name = "Gallardo"
            });
            Cars.Add(new Car
            {
                CarId = 16,
                ManufactureId = 5,
                Name = "Countach"
            });
            Cars.Add(new Car
            {
                CarId = 17,
                ManufactureId = 5,
                Name = "Aventador"
            });
            Cars.Add(new Car
            {
                CarId = 18,
                ManufactureId = 5,
                Name = "Diablo SV"
            });
            Cars.Add(new Car
            {
                CarId = 19,
                ManufactureId = 5,
                Name = "Murcielago"
            });

            //Koenigsegg
            Cars.Add(new Car
            {
                CarId = 20,
                ManufactureId = 6,
                Name = "CCXR"
            });
            Cars.Add(new Car
            {
                CarId = 21,
                ManufactureId = 6,
                Name = "Agera"
            });

            //Audi
            Cars.Add(new Car
            {
                CarId = 22,
                ManufactureId = 7,
                Name = "TT RS 2012"
            });
            Cars.Add(new Car
            {
                CarId = 23,
                ManufactureId = 7,
                Name = "R8 V10 Coupe"
            });
            Cars.Add(new Car
            {
                CarId = 24,
                ManufactureId = 7,
                Name = "Quattro B2"
            });

            //Porsche
            Cars.Add(new Car
            {
                CarId = 25,
                ManufactureId = 8,
                Name = "911 Turbo 2009"
            });
            Cars.Add(new Car
            {
                CarId = 26,
                ManufactureId = 8,
                Name = "911 GT3 RS"
            });
            Cars.Add(new Car
            {
                CarId = 27,
                ManufactureId = 8,
                Name = "918 Spyder Concept"
            });
            Cars.Add(new Car
            {
                CarId = 28,
                ManufactureId = 8,
                Name = "Carrera GT"
            });
        }

        public List<Car> GetCarsByManufactureId(int id)
        {
            return Cars.Where(c => c.ManufactureId == id).ToList();
        }
    }
}
