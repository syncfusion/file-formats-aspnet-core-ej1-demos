#region Copyright
// Copyright Syncfusion Inc. 2001 - 2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Collections;
using System.Data;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;
using Syncfusion.Pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;
using System.Xml;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace samplebrowser.Controllers.DocIO
{   
    public partial class DocIOController : Controller
    {    
        public ActionResult SalesInvoice(int id, string SaveOption, string Button)
        {
            ArrayList orderID = GetTestOrderID();
            ViewData.Add("id", new SelectList(orderID));
            if (SaveOption == null)
                return View();
            string basePath = _hostingEnvironment.WebRootPath;
            string dataPath = basePath + @"/DocIO/SalesInvoiceDemo.doc";
            string contenttype1 = "application/msword";
            FileStream fileStreamPath = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (Button == "View Template")
                return File(fileStreamPath, contenttype1, "SalesInvoiceDemo.doc");
                    
            // Create a new document
            WordDocument doc = new WordDocument();
            // Load the template.
            string dataPathSales = basePath + @"/DocIO/SalesInvoiceDemo.doc";
            FileStream fileStream = new FileStream(dataPathSales, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            doc.Open(fileStream, FormatType.Automatic);
            //Create MailMergeDataTable
            MailMergeDataTable mailMergeDataTableOrder = GetTestOrder(id);
            MailMergeDataTable mailMergeDataTableOrderTotals = GetTestOrderTotals(id);
            MailMergeDataTable mailMergeDataTableOrderDetails = GetTestOrderDetails(id);           
            // Execute Mail Merge with groups.
            doc.MailMerge.ExecuteGroup(mailMergeDataTableOrder);
            doc.MailMerge.ExecuteGroup(mailMergeDataTableOrderTotals);
            // Using Merge events to do conditional formatting during runtime.
            doc.MailMerge.MergeField += new MergeFieldEventHandler(MailMerge_MergeField);           
            doc.MailMerge.ExecuteGroup(mailMergeDataTableOrderDetails);
            FormatType type = FormatType.Docx;
            string filename = "Sample.docx";
            string contenttype = "application/vnd.ms-word.document.12";
            #region Document SaveOption
            //Save as .doc format
            if (SaveOption == "WordDoc")
            {
                type = FormatType.Doc;
                filename = "Sample.doc";
                contenttype = "application/msword";
            }
            //Save as .xml format
            else if (SaveOption == "WordML")
            {
                type = FormatType.WordML;
                filename = "Sample.xml";
                contenttype = "application/msword";
            }
            #endregion Document SaveOption
            MemoryStream ms = new MemoryStream();
            doc.Save(ms, type);
            doc.Close();
            ms.Position = 0;
            return File(ms, contenttype, filename);
        }
        private void MailMerge_MergeField(object sender, MergeFieldEventArgs args)
        {
            // Conditionally format data during Merge.
            if (args.RowIndex % 2 == 0)
            {
                args.CharacterFormat.TextColor = Syncfusion.Drawing.Color.DarkBlue;
            }

        }

        private MailMergeDataTable GetTestOrder(int TestOrderId)
        {
            List<TestOrder> orders = new List<TestOrder>();
            FileStream fs = new FileStream(_hostingEnvironment.WebRootPath + @"/DocIO/TestOrder.xml", FileMode.Open, FileAccess.Read); 
            XmlReader reader = XmlReader.Create(fs);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrders")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            while (reader.LocalName != "TestOrders")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "TestOrder":
                            TestOrder testOrder = GetTestOrder(reader);
                            if (testOrder.OrderID == TestOrderId.ToString())
                            {
                                orders.Add(testOrder);
                                break;
                            }
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrders") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }

            MailMergeDataTable dataTable = new MailMergeDataTable("Orders", orders);
            reader.Dispose();
            fs.Dispose();
            return dataTable;
            
        }

        private MailMergeDataTable GetTestOrderDetails(int TestOrderId)
        {
            List<TestOrderDetail> orders = new List<TestOrderDetail>();
            FileStream fs = new FileStream(_hostingEnvironment.WebRootPath + @"/DocIO/TestOrderDetails.xml", FileMode.Open, FileAccess.Read);
            XmlReader reader = XmlReader.Create(fs);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrderDetails")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            while (reader.LocalName != "TestOrderDetails")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "TestOrderDetail":
                            TestOrderDetail testOrder = GetTestOrderDetail(reader);
                            if (testOrder.OrderID == TestOrderId.ToString())
                            {
                                orders.Add(testOrder);
                                break;
                            }
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrderDetails") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }

            MailMergeDataTable dataTable = new MailMergeDataTable("Order", orders);          
            reader.Dispose();
            fs.Dispose();
            return dataTable;
            
        }
        private MailMergeDataTable GetTestOrderTotals(int TestOrderId)
        {
            List<TestOrderTotal> orders = new List<TestOrderTotal>();
            FileStream fs = new FileStream(_hostingEnvironment.WebRootPath + @"/DocIO/OrderTotals.xml", FileMode.Open, FileAccess.Read);               
            XmlReader reader = XmlReader.Create(fs);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrderTotals")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            while (reader.LocalName != "TestOrderTotals")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "TestOrderTotal":
                            TestOrderTotal testOrder = GetTestOrderTotal(reader);
                            if (testOrder.OrderID == TestOrderId.ToString())
                            {
                                orders.Add(testOrder);
                                break;
                            }
                            break;
                    }
                    reader.Read();
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrderTotals") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }

            MailMergeDataTable dataTable = new MailMergeDataTable("OrderTotals", orders);
            reader.Dispose();
            fs.Dispose();
            return dataTable;
        }

        private TestOrder GetTestOrder(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrder")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            TestOrder testOrder = new TestOrder();
            while (reader.LocalName != "TestOrder")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "ShipName":
                            testOrder.ShipName = reader.ReadElementContentAsString();
                            break;
                        case "ShipAddress":
                            testOrder.ShipAddress = reader.ReadElementContentAsString();
                            break;
                        case "ShipCity":
                            testOrder.ShipCity = reader.ReadElementContentAsString();
                            break;
                        case "ShipPostalCode":
                            testOrder.ShipPostalCode = reader.ReadElementContentAsString();
                            break;
                        case "ShipCountry":
                            testOrder.ShipCountry = reader.ReadElementContentAsString();
                            break;
                        case "PostalCode":
                            testOrder.PostalCode = reader.ReadElementContentAsString();
                            break;
                        case "CustomerID":
                            testOrder.CustomerID = reader.ReadElementContentAsString();
                            break;
                        case "Customers.CompanyName":
                            testOrder.Customers_CompanyName = reader.ReadElementContentAsString();
                            break;
                        case "HomePage":
                            testOrder.Salesperson = reader.ReadElementContentAsString();
                            break;
                        case "Address":
                            testOrder.Address = reader.ReadElementContentAsString();
                            break;
                        case "City":
                            testOrder.City = reader.ReadElementContentAsString();
                            break;
                        case "Country":
                            testOrder.Country = reader.ReadElementContentAsString();
                            break;
                        case "OrderID":
                            testOrder.OrderID = reader.ReadElementContentAsString();
                            break;
                        case "OrderDate":
                            testOrder.OrderDate = reader.ReadElementContentAsString();
                            break;
                        case "RequiredDate":
                            testOrder.RequiredDate = reader.ReadElementContentAsString();
                            break;
                        case "ShippedDate":
                            testOrder.ShippedDate = reader.ReadElementContentAsString();
                            break;
                        case "Shippers.CompanyName":
                            testOrder.Shippers_CompanyName = reader.ReadElementContentAsString();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrders") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return testOrder;
        }
        private ArrayList GetTestOrderID()
        {
            FileStream fs = new FileStream(_hostingEnvironment.WebRootPath + @"/DocIO/TestOrder.xml", FileMode.Open, FileAccess.Read);             
            XmlReader reader = XmlReader.Create(fs);

            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrders")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();
            ArrayList orderId = new ArrayList();

            while (reader.LocalName != "TestOrders")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "OrderID":
                            orderId.Add(reader.ReadElementContentAsString());
                            break;
                        default:
                            break;
                    }
                    reader.Read();
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrders") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }

            return orderId;
        }
        private TestOrderDetail GetTestOrderDetail(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrderDetail")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            TestOrderDetail testOrderDetail = new TestOrderDetail();
            while (reader.LocalName != "TestOrderDetail")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "OrderID":
                            testOrderDetail.OrderID = reader.ReadElementContentAsString();
                            break;
                        case "ProductID":
                            testOrderDetail.ProductID = reader.ReadElementContentAsString();
                            break;
                        case "ProductName":
                            testOrderDetail.ProductName = reader.ReadElementContentAsString();
                            break;
                        case "UnitPrice":
                            testOrderDetail.UnitPrice = reader.ReadElementContentAsString();
                            break;
                        case "Quantity":
                            testOrderDetail.Quantity = reader.ReadElementContentAsString();
                            break;
                        case "Discount":
                            testOrderDetail.Discount = reader.ReadElementContentAsString();
                            break;
                        case "ExtendedPrice":
                            testOrderDetail.ExtendedPrice = reader.ReadElementContentAsString();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrderDetail") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return testOrderDetail;
        }
        private TestOrderTotal GetTestOrderTotal(XmlReader reader)
        {
            if (reader == null)
                throw new Exception("reader");

            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();

            if (reader.LocalName != "TestOrderTotal")
                throw new XmlException("Unexpected xml tag " + reader.LocalName);

            reader.Read();

            while (reader.NodeType == XmlNodeType.Whitespace)
                reader.Read();

            TestOrderTotal testOrderTotal = new TestOrderTotal();
            while (reader.LocalName != "TestOrderTotal")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "OrderID":
                            testOrderTotal.OrderID = reader.ReadElementContentAsString();
                            break;
                        case "Subtotal":
                            testOrderTotal.Subtotal = reader.ReadElementContentAsString();
                            break;
                        case "Freight":
                            testOrderTotal.Freight = reader.ReadElementContentAsString();
                            break;
                        case "Total":
                            testOrderTotal.Total = reader.ReadElementContentAsString();
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
                else
                {
                    reader.Read();
                    if ((reader.LocalName == "TestOrderTotal") && reader.NodeType == XmlNodeType.EndElement)
                        break;
                }
            }
            return testOrderTotal;
        }
    }
    

    public class TestOrderDetail
    {
        #region Fields

        private string m_orderID;
        private string m_productID;
        private string m_productName;
        private string m_unitPrice;
        private string m_quantity;
        private string m_discount;
        private string m_extendedPrice;
        #endregion

        #region Properties

        public string OrderID
        {
            get { return m_orderID; }
            set { m_orderID = value; }
        }

        public string ProductID
        {
            get { return m_productID; }
            set { m_productID = value; }
        }
        public string ProductName
        {
            get { return m_productName; }
            set { m_productName = value; }
        }
        public string UnitPrice
        {
            get { return m_unitPrice; }
            set { m_unitPrice = value; }
        }
        public string Quantity
        {
            get { return m_quantity; }
            set { m_quantity = value; }
        }
        public string Discount
        {
            get { return m_discount; }
            set { m_discount = value; }
        }
        public string ExtendedPrice
        {
            get { return m_extendedPrice; }
            set { m_extendedPrice = value; }
        }

        #endregion

        #region Constructor       
        public TestOrderDetail()
        { }
        #endregion
    }
    public class TestOrderTotal
    {
        #region Fields

        private string m_orderID;
        private string m_subTotal;
        private string m_freight;
        private string m_total;
        #endregion

        #region Properties

        public string OrderID
        {
            get { return m_orderID; }
            set { m_orderID = value; }
        }

        public string Subtotal
        {
            get { return m_subTotal; }
            set { m_subTotal = value; }
        }
        public string Freight
        {
            get { return m_freight; }
            set { m_freight = value; }
        }
        public string Total
        {
            get { return m_total; }
            set { m_total = value; }
        }
        #endregion

        #region Constructor       
        public TestOrderTotal()
        { }
        #endregion
    }
    public class TestOrder
    {
        #region Fields

        private string m_orderID;
        private string m_shipName;
        private string m_shipAddress;
        private string m_shipCity;
        private string m_shipPostalCode;
        private string m_shipCountry;
        private string m_customerID;
        private string m_address;
        private string m_postalCode;
        private string m_city;
        private string m_country;
        private string m_salesPerson;
        private string m_customersCompanyName;
        private string m_orderDate;
        private string m_requiredDate;
        private string m_shippedDate;
        private string m_shippersCompanyName;
        #endregion

        #region Properties

        public string ShipName
        {
            get { return m_shipName; }
            set { m_shipName = value; }
        }

        public string ShipAddress
        {
            get { return m_shipAddress; }
            set { m_shipAddress = value; }
        }
        public string ShipCity
        {
            get { return m_shipCity; }
            set { m_shipCity = value; }
        }
        public string ShipPostalCode
        {
            get { return m_shipPostalCode; }
            set { m_shipPostalCode = value; }
        }
        public string PostalCode
        {
            get { return m_postalCode; }
            set { m_postalCode = value; }
        }
        public string ShipCountry
        {
            get { return m_shipCountry; }
            set { m_shipCountry = value; }
        }
        public string CustomerID
        {
            get { return m_customerID; }
            set { m_customerID = value; }
        }
        public string Customers_CompanyName
        {
            get { return m_customersCompanyName; }
            set { m_customersCompanyName = value; }
        }
        public string Address
        {
            get { return m_address; }
            set { m_address = value; }
        }

        public string City
        {
            get { return m_city; }
            set { m_city = value; }
        }

        public string Country
        {
            get { return m_country; }
            set { m_country = value; }
        }
        public string Salesperson
        {
            get { return m_salesPerson; }
            set { m_salesPerson = value; }
        }
        public string OrderID
        {
            get { return m_orderID; }
            set { m_orderID = value; }
        }
        public string OrderDate
        {
            get { return m_orderDate; }
            set { m_orderDate = value; }
        }
        public string RequiredDate
        {
            get { return m_requiredDate; }
            set { m_requiredDate = value; }
        }
        public string ShippedDate
        {
            get { return m_shippedDate; }
            set { m_shippedDate = value; }
        }
        public string Shippers_CompanyName
        {
            get { return m_shippersCompanyName; }
            set { m_shippersCompanyName = value; }
        }
        #endregion

        #region Constructor       
        public TestOrder()
        { }
        #endregion
    }
}
