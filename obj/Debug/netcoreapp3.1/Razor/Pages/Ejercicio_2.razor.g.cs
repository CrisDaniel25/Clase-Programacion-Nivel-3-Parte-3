#pragma checksum "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad85779df71fbee9a2c839fafc14af6c6f933cc4"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Tarea_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\crist\Desktop\Programacion III\Tarea-3\_Imports.razor"
using Tarea_3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
using Tarea_3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ejercicio-2")]
    public partial class Ejercicio_2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Ejercicio #2</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"row\">\r\n        <p>Programa que muestre la prediccion del clima actualizada para santo domingo (o su provincia), sin importar cuando se ejecute su aplicacion debe de mostrar estos datos. </p>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col justify-content-center");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-dark");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                                   Reload

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Recargar");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "<hr><br>\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col justify-content-center");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "list-group");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.AddMarkupContent(20, "<li class=\"list-group-item text-center\">\r\n                <h3 class=\"text-center\"><strong>Santo Domingo,DO</strong></h3>\r\n            </li>\r\n            ");
            __builder.OpenElement(21, "li");
            __builder.AddAttribute(22, "class", "list-group-item text-center");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<h3 class=\"text-center\">Fecha de la ISO</h3>\r\n                ");
            __builder.OpenElement(25, "p");
            __builder.OpenElement(26, "strong");
            __builder.AddContent(27, 
#nullable restore
#line 20 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                            Date.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "li");
            __builder.AddAttribute(31, "class", "list-group-item text-center");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.AddMarkupContent(33, "<h3 class=\"text-center\">Temperatura</h3>\r\n                ");
            __builder.OpenElement(34, "p");
            __builder.AddMarkupContent(35, "<strong>Máxima: </strong>");
            __builder.AddContent(36, 
#nullable restore
#line 24 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                             TempmaxC

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "°C  ");
            __builder.AddMarkupContent(38, "<strong>Mínima: </strong>");
            __builder.AddContent(39, 
#nullable restore
#line 24 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                                                                   TempminC

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "°C");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "li");
            __builder.AddAttribute(44, "class", "list-group-item text-center");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<h3 class=\"text-center\">Sensación de la temperatura</h3>\r\n                ");
            __builder.OpenElement(47, "p");
            __builder.AddMarkupContent(48, "<strong>Máxima: </strong>");
            __builder.AddContent(49, 
#nullable restore
#line 28 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                             TempfeelLikemaxC

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "°C  ");
            __builder.AddMarkupContent(51, "<strong>Mínima: </strong>");
            __builder.AddContent(52, 
#nullable restore
#line 28 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                                                                           TempfeelLikeminC

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, "°C");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "list-group-item text-center");
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.AddMarkupContent(59, "<h3 class=\"text-center\">Humedad</h3>\r\n                ");
            __builder.OpenElement(60, "p");
            __builder.AddMarkupContent(61, "<strong>Máxima: </strong>");
            __builder.AddContent(62, 
#nullable restore
#line 32 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                             Humiditymax

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(63, "   ");
            __builder.AddMarkupContent(64, "<strong>Promedio: </strong>");
            __builder.AddContent(65, 
#nullable restore
#line 32 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                                                                       Humidityavg

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, "   ");
            __builder.AddMarkupContent(67, "<strong>Mínima: </strong>");
            __builder.AddContent(68, 
#nullable restore
#line 32 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                                                                                                               Humiditymin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "li");
            __builder.AddAttribute(72, "class", "list-group-item text-center");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.AddMarkupContent(74, "<h3 class=\"text-center\">Velocidad de viento</h3>\r\n                 ");
            __builder.OpenElement(75, "p");
            __builder.AddMarkupContent(76, "<strong>Máxima: </strong>");
            __builder.AddContent(77, 
#nullable restore
#line 36 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                              windSpeedmaxKPH

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, " KPH  ");
            __builder.AddMarkupContent(79, "<strong>Promedio: </strong>");
            __builder.AddContent(80, 
#nullable restore
#line 36 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                                                                               windSpeedavgKPH

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(81, " KPH   ");
            __builder.AddMarkupContent(82, "<strong>Mínima: </strong>");
            __builder.AddContent(83, 
#nullable restore
#line 36 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                                                                                                                                               windSpeedminKPH

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(84, " KPH");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.OpenElement(87, "li");
            __builder.AddAttribute(88, "class", "list-group-item text-center");
            __builder.AddMarkupContent(89, "\r\n                ");
            __builder.AddMarkupContent(90, "<h3 class=\"text-center\">Clima</h3>\r\n                ");
            __builder.OpenElement(91, "p");
            __builder.OpenElement(92, "strong");
            __builder.AddContent(93, 
#nullable restore
#line 40 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
                            weatherPhrase

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\crist\Desktop\Programacion III\Tarea-3\Pages\Ejercicio_2.razor"
       
    private string URL_API = "https://api.aerisapi.com/conditions/summary/santo domingo,do?&format=json&from=now&to=now&fields=loc,periods.dateTimeISO,periods.temp,periods.feelslike,periods.humidity,periods.windSpeed,periods.weather&client_id=hmzavWkezJCkt1FOsVsTu&client_secret=DwtS8xlQFhCkBUtVQwi9vMJd69mPIZaZyabQMjH1";
    public Clima weather {get; set;}
    public DateTime Date {get; set;}
    public double latitude {get; set;}
    public double length {get; set;}
    public double TempmaxC {get; set;}
    public double TempminC {get; set;}
    public double TempfeelLikemaxC {get; set;}
    public double TempfeelLikeminC {get; set;}
    public double Humiditymax {get; set;}
    public double Humidityavg {get; set;}
    public double Humiditymin {get; set;}
    public double windSpeedmaxKPH {get; set;}
    public double windSpeedavgKPH {get; set;}
    public double windSpeedminKPH {get; set;}
    public string weatherPhrase {get; set;}

    protected override async Task OnInitializedAsync()
    {
        await Reload();
    }

    public async Task Reload()
    {
        HttpClient http = new HttpClient();
        var response = await http.GetAsync(URL_API);    

        if (response.IsSuccessStatusCode)
        {
            var resultToString = await response.Content.ReadAsStringAsync();
            weather = JsonConvert.DeserializeObject<Clima>(resultToString);
            foreach (var result in weather.response) 
            {   
                foreach (var res in result.periods)
                {
                    Date = res.dateTimeISO;
                    TempmaxC = res.temp.maxC;
                    TempminC = res.temp.minC;
                    TempfeelLikemaxC = res.feelslike.maxC;
                    TempfeelLikeminC = res.feelslike.minC;
                    Humiditymax = res.humidity.max;
                    Humidityavg = res.humidity.avg;
                    Humiditymin = res.humidity.min;
                    windSpeedmaxKPH = res.windSpeed.maxKPH;
                    windSpeedavgKPH = res.windSpeed.avgKPH;
                    windSpeedminKPH = res.windSpeed.minKPH;
                    weatherPhrase = res.weather.phrase;
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
