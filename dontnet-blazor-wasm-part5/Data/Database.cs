using dontnet_blazor_wasm_part5.Models;

namespace dontnet_blazor_wasm_part5.Data
{
    public class Database
    {
        List<Manufacture> companies { get; set; } = new List<Manufacture>();
        List<Car> cars { get; set; } = new List<Car>();

        public Database()
        {
            companies.Add(new Manufacture
            {
                ManufactureId = 1,
                Name = "Mitsubishi"
            });
            companies.Add(new Manufacture
            {
                ManufactureId = 2,
                Name = "Ferrari"
            });
            companies.Add(new Manufacture
            {
                ManufactureId = 3,
                Name = "Ford"
            });
            companies.Add(new Manufacture
            {
                ManufactureId = 4,
                Name = "Nissas"
            });
            companies.Add(new Manufacture
            {
                ManufactureId = 5,
                Name = "Lamborghini"
            });
            companies.Add(new Manufacture
            {
                ManufactureId = 6,
                Name = "Koenigsegg"
            });
            companies.Add(new Manufacture
            {
                ManufactureId = 7,
                Name = "Audi"
            });
            companies.Add(new Manufacture
            {
                ManufactureId = 8,
                Name = "Porsche"
            });

            //Mitsubishi
            cars.Add(new Car
            {
                CarId = 1,
                ManufactureId = 1,
                Name = "Lancer Evolution X"
            });
            cars.Add(new Car
            {
                CarId = 2,
                ManufactureId = 1,
                Name = "Lancer Evolution VI"
            });

            //Ferrari
            cars.Add(new Car
            {
                CarId = 3,
                ManufactureId = 2,
                Name = "F40"
            });
            cars.Add(new Car
            {
                CarId = 4,
                ManufactureId = 2,
                Name = "Testarossa"
            });
            cars.Add(new Car
            {
                CarId = 5,
                ManufactureId = 2,
                Name = "458 Spider"
            });
            cars.Add(new Car
            {
                CarId = 6,
                ManufactureId = 2,
                Name = "599 GTO"
            });

            //Ford
            cars.Add(new Car
            {
                CarId = 7,
                ManufactureId = 3,
                Name = "Focus RS"
            });
            cars.Add(new Car
            {
                CarId = 8,
                ManufactureId = 3,
                Name = "Shelby GT500"
            });
            cars.Add(new Car
            {
                CarId = 9,
                ManufactureId = 3,
                Name = "Musang GT Premium"
            });
            cars.Add(new Car
            {
                CarId = 10,
                ManufactureId = 3,
                Name = "GT (2005)"
            });

            //Nissan
            cars.Add(new Car
            {
                CarId = 11,
                ManufactureId = 4,
                Name = "Silvia"
            });
            cars.Add(new Car
            {
                CarId = 12,
                ManufactureId = 4,
                Name = "Skyline GT-R V-SPEC R34"
            });
            cars.Add(new Car
            {
                CarId = 13,
                ManufactureId = 4,
                Name = "370Z"
            });
            cars.Add(new Car
            {
                CarId = 14,
                ManufactureId = 4,
                Name = "GT-R Premium R35"
            });

            //Lamborghini
            cars.Add(new Car
            {
                CarId = 15,
                ManufactureId = 5,
                Name = "Gallardo"
            });
            cars.Add(new Car
            {
                CarId = 16,
                ManufactureId = 5,
                Name = "Countach"
            });
            cars.Add(new Car
            {
                CarId = 17,
                ManufactureId = 5,
                Name = "Aventador"
            });
            cars.Add(new Car
            {
                CarId = 18,
                ManufactureId = 5,
                Name = "Diablo SV"
            });
            cars.Add(new Car
            {
                CarId = 19,
                ManufactureId = 5,
                Name = "Murcielago"
            });

            //Koenigsegg
            cars.Add(new Car
            {
                CarId = 20,
                ManufactureId = 6,
                Name = "CCXR"
            });
            cars.Add(new Car
            {
                CarId = 21,
                ManufactureId = 6,
                Name = "Agera"
            });

            //Audi
            cars.Add(new Car
            {
                CarId = 22,
                ManufactureId = 7,
                Name = "TT RS 2012"
            });
            cars.Add(new Car
            {
                CarId = 23,
                ManufactureId = 7,
                Name = "R8 V10 Coupe"
            });
            cars.Add(new Car
            {
                CarId = 24,
                ManufactureId = 7,
                Name = "Quattro B2"
            });

            //Porsche
            cars.Add(new Car
            {
                CarId = 25,
                ManufactureId = 8,
                Name = "911 Turbo 2009"
            });
            cars.Add(new Car
            {
                CarId = 26,
                ManufactureId = 8,
                Name = "911 GT3 RS"
            });
            cars.Add(new Car
            {
                CarId = 27,
                ManufactureId = 8,
                Name = "918 Spyder Concept"
            });
            cars.Add(new Car
            {
                CarId = 28,
                ManufactureId = 8,
                Name = "Carrera GT"
            });
        }

        public List<Car> GetCarsByManufactureId(int id)
        {
            return cars.Where(c => c.ManufactureId == id).ToList();
        }

        public Car GetCarById(int id)
        {
            return cars.Find(c => c.CarId == id);
        }

        public List<CarDto> GetAllCars()
        {
            return cars.Select(c => new CarDto
            {
                CarId = c.CarId,
                Name = c.Name,
                Manufacture = companies.Where(r => r.ManufactureId == c.ManufactureId).Select(r => r.Name).First()
            }).ToList();
        }

        public void EditCar(Car editedCar)
        {
            var existingCar = cars.FirstOrDefault(c => c.CarId == editedCar.CarId);

            existingCar.Name = editedCar.Name;
            existingCar.ManufactureId = editedCar.ManufactureId;
        }

        public List<Manufacture> GetAllManufactures()
        {
            return companies;
        }
    }

    public class CarDto
    {
        public int CarId { get; set; }

        public string Name { get; set; }

        public string Manufacture { get; set; }
    }
}
