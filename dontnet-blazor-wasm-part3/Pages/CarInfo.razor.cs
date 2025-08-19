using Microsoft.AspNetCore.Components;

namespace dontnet_blazor_wasm_part3.Pages
{
    public partial class CarInfo
    {
        [Parameter]
        public int Id { get; set; }

        [Parameter]
        public string Name { get; set; }
    }
}
