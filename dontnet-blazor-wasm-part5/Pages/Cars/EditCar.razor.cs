using dontnet_blazor_wasm_part5.Data;
using dontnet_blazor_wasm_part5.Models;
using Microsoft.AspNetCore.Components;

namespace dontnet_blazor_wasm_part5.Pages.Cars
{
    public partial class EditCar
    {
        private readonly Database _database;

        public EditCar(Database database)
        {
            _database = database;
        }

        [Parameter]
        public int Id { get; set; }
        public Car ExistingCar { get; set; }
        public List<Manufacture> CarCompanies { get; set; }

        protected override void OnInitialized()
        {
            ExistingCar = _database.GetCarById(Id);
            CarCompanies = _database.GetAllManufactures();
        }

        public void UpdateCar()
        {
            _database.EditCar(ExistingCar);
            Console.WriteLine("The updated car info: Car Model: " + ExistingCar.Name + " - ManudactureId: " + ExistingCar.ManufactureId);
        }
    }
}
