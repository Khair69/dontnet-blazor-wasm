using dontnet_blazor_wasm_part5.Data;
using dontnet_blazor_wasm_part5.Models;
using Microsoft.AspNetCore.Components;

namespace dontnet_blazor_wasm_part5.Pages.Cars
{
    public partial class CarInfo
    {
        private readonly Database _database;

        public CarInfo(Database database)
        {
            _database = database;
        }

        [Parameter]
        public int Id { get; set; }
        public Car Car { get; set; }

        protected override void OnInitialized()
        {
            Car = _database.GetCarById(Id);
        }
    }
}
