namespace ServiceAppointmentSystem.Models.ViewModels
{
    public class OrderDetailViewModel
    {
        public int OrderId { get; set; }    

        public int ProductId { get; set; }  

        public string ProductName { get; set; } 

        public int ProductCount { get; set; }

        public double TotalPrice { get; set; }
    }
}
