using ClosedXML.Excel;
using GemBox.Document;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using TravellandAdminApplication.Models;

namespace TravellandAdminApplication.Controllers
{
    public class ReservationController : Controller
    {
        public ReservationController()
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            string URL = "https://localhost:5001/api/Admin/GetAllActiveReservations";

            HttpResponseMessage response = client.GetAsync(URL).Result;
            var data = response.Content.ReadAsAsync<List<Reservation>>().Result;
            return View(data);
        }
        public IActionResult Details(Guid id)
        {
            HttpClient client = new HttpClient();


            string URI = "https://localhost:5001/api/Admin/GetDetailsForOffer";

            var model = new
            {
                Id = id
            };

            HttpContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = client.PostAsync(URI, content).Result;


            var result = responseMessage.Content.ReadAsAsync<Reservation>().Result;


            return View(result);
        }
        [HttpGet]
        public FileContentResult ExportAllReservations()
        {
            string fileName = "Reservations.xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("All Reservations");

                worksheet.Cell(1, 1).Value = "Reservation Id";
                worksheet.Cell(1, 2).Value = "Costumer Email";


                HttpClient client = new HttpClient();


                string URI = "https://localhost:5001/api/Admin/GetAllActiveReservations";

                HttpResponseMessage responseMessage = client.GetAsync(URI).Result;

                var result = responseMessage.Content.ReadAsAsync<List<Reservation>>().Result;

                for (int i = 1; i <= result.Count(); i++)
                {
                    var item = result[i - 1];

                    worksheet.Cell(i + 1, 1).Value = item.id.ToString();
                    worksheet.Cell(i + 1, 2).Value = item.Client.Email;

                    for (int p = 0; p < item.Offers.Count(); p++)
                    {
                        worksheet.Cell(1, p + 3).Value = "Offer-" + (p + 1);
                        worksheet.Cell(i + 1, p + 3).Value = item.Offers.ElementAt(p).SelectedOffer.OfferDestination;
                    }
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, contentType, fileName);
                }

            }
        }

        public FileContentResult CreateInvoice(Guid id)
        {
            HttpClient client = new HttpClient();


            string URI = "https://localhost:5001/api/Admin/GetDetailsForOffer";

            var model = new
            {
                Id = id
            };

            HttpContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = client.PostAsync(URI, content).Result;


            var result = responseMessage.Content.ReadAsAsync<Reservation>().Result;

            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Invoice.docx");
            var document = DocumentModel.Load(templatePath);


            document.Content.Replace("{{ReservationNumber}}", result.id.ToString());
            document.Content.Replace("{{UserName}}", result.Client.UserName);

            StringBuilder sb = new StringBuilder();

            var totalPrice = 0.0;

            foreach (var item in result.Offers)
            {
                totalPrice += item.Quantity * item.SelectedOffer.OfferPrice;
                sb.AppendLine(item.SelectedOffer.OfferDestination + " with quantity of: " + item.Quantity + " and price of: " + item.SelectedOffer.OfferPrice + "euros");
            }


            document.Content.Replace("{{OfferList}}", sb.ToString());
            document.Content.Replace("{{TotalPrice}}", totalPrice.ToString() + "$");


            var stream = new MemoryStream();

            document.Save(stream, new PdfSaveOptions());

            return File(stream.ToArray(), new PdfSaveOptions().ContentType, "ExportInvoice.pdf");
        }
    } 
}

    
