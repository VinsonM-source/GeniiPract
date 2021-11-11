using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GeniiPract.Pages
{
    public class InvoiceModel : PageModel
    {
		public void OnGet()
		{
		}
            public class InvoiceData
        {
	public InvoiceDataRow[] DataRows = new InvoiceDataRow[23];  
	public string LogoFile = "";  
	public string BillerAddress = "";  
	public string BillToAddress = "";  
	public string ShipToAddress = "";  
	public string InvoiceDate = "";  
	public string InvoiceNumber = "";  
	public string DueDate = "";
    public string PONumber = "";  
	public string PercentTax = "";  
    public string Subtotal = "";  
    public string Total = "";  
	public int RowCount = 0;   

	}

    }
}


