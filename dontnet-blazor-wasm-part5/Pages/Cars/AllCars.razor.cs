using dontnet_blazor_wasm_part5.Data;

namespace dontnet_blazor_wasm_part5.Pages.Cars
{
    public partial class AllCars
    {
        private readonly Database _database;

        public AllCars(Database database)
        {
            _database = database;
        }

        public List<CarDto> Cars { get; set; } = new();

        protected override void OnInitialized()
        {
            Cars = _database.GetAllCars();
            base.OnInitialized();
        }
    }
}
