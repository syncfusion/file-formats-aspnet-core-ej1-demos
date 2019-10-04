window.GroupingList = [ "FILE FORMATS"];

//Controls List
window.SampleControls = [
     { "name": "PDF" }, { "name": "Presentation" }, { "name": "DocIO" }, { "name": "XlsIO" }
];
//Samples List
window.SamplesList = [
    {
         "name": "PDF", "id": "Pdf", "childcount": "1", "Group": "FILE FORMATS", "controller": "Pdf", "action": "Default", "samples": [
             { "id": "1", "name": "Getting Started", "controller": "Pdf", "action": "Default", "childcount": "0" },
             {
                                            "id": "2", "name": "Product Showcase", "controller": "Pdf", "action": "JobApplication", "childcount": "2", "samples": [
                                         { "id": "1", "name": "Job Application", "controller": "Pdf", "action": "JobApplication", "childcount": "0" },
                                         { "id": "2", "name": "ZUGFeRD Invoice", "controller": "Pdf", "action": "Zugferd", "childcount": "0" }										 
                                            ]
                                        },  
                                          {
                                                "id": "3", "name": "Drawing Text", "controller": "Pdf", "action": "TextFlow", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Text Flow", "controller": "Pdf", "action": "TextFlow", "childcount": "0" },                
                                           { "id": "2", "name": "Bullets and Lists", "controller": "Pdf", "action": "BulletsandLists", "childcount": "0" },
										   { "id": "3", "name": "RTL Text", "controller": "Pdf", "action": "RTLSupport", "childcount": "0" },
                                           { "id": "4", "name": "OpenType Font", "controller": "Pdf", "action": "OpenTypeFont", "childcount": "0" }
                                                ]
                                            },										
                                          {
                                              "id": "4", "name": "Graphics", "controller": "Pdf", "action": "Barcode", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Barcode", "controller": "Pdf", "action": "Barcode", "childcount": "0"},
                                           { "id": "2", "name": "Drawing Shapes", "controller": "Pdf", "action": "DrawingShapes", "childcount": "0" },
                                           { "id": "3", "name": "Graphic Brushes", "controller": "Pdf", "action": "GraphicBrushes", "childcount": "0" },
										   { "id": "4", "name": "Image Insertion", "controller": "Pdf", "action": "ImageInsertion", "childcount": "0"},
                                              ]
                                          },
                                          {
                                              "id": "5", "name": "Tables", "controller": "Pdf", "action": "AdventureCycle", "childcount": "1", "samples": [   
                                         { "id": "2", "name": "Adventure Cycle Works", "controller": "Pdf", "action": "AdventureCycle", "childcount": "0" },
                                         { "id": "3", "name": "Table Features", "controller": "Pdf", "action": "TableFeatures", "childcount": "0" }]
                                          },                                            
                                        {
										 "id": "6", "name": "Import and Export", "controller": "Pdf", "action": "ExtractText", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Text Extraction", "controller": "Pdf", "action": "ExtractText", "childcount": "0" },
                                         { "id": "2", "name": "Find Text", "controller": "Pdf", "action": "FindText", "childcount": "0" },
										 { "id": "3", "name": "TIFF To PDF", "controller": "Pdf", "action": "TiffToPDF", "childcount": "0" }]
                                        }, 
                                             {
                                                 "id": "7", "name": "Security", "controller": "Pdf", "action": "Encryption", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Encryption", "controller": "Pdf", "action": "Encryption", "childcount": "0" },
                                         { "id": "2", "name": "Digital Signature", "controller": "Pdf", "action": "DigitalSignature", "childcount": "0"}
                                                 ]
                                             },

                                              {
                                                  "id": "8", "name": "Settings", "controller": "Pdf", "action": "DocumentSettings", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Document Settings", "controller": "Pdf", "action": "DocumentSettings", "childcount": "0" },
                                           { "id": "2", "name": "Page Settings", "controller": "Pdf", "action": "PageSettings", "childcount": "0" },
                                           { "id": "3", "name": "Headers and Footers", "controller": "Pdf", "action": "HeadersandFooters", "childcount": "0" },
                                           { "id": "4", "name": "Layers", "controller": "Pdf", "action": "Layers", "childcount": "0" }
                                                  ]
                                              },
                                              {
                                                  "id": "9", "name": "User Interaction", "controller": "Pdf", "action": "InteractiveFeatures", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Interactive Features", "controller": "Pdf", "action": "InteractiveFeatures", "childcount": "0" },
                                           { "id": "2", "name": "Form Filling", "controller": "Pdf", "action": "FormFilling", "childcount": "0"},
                                           { "id": "3", "name": "Portfolio", "controller": "Pdf", "action": "Portfolio", "childcount": "0" },
                                           { "id": "4", "name": "Annotations", "controller": "Pdf", "action": "AnnotationFlatten", "childcount": "0" },
										   { "id": "5", "name": "Named Destination", "controller": "Pdf", "action": "NamedDestination", "childcount": "0"},
                                           { "id": "6", "name": "Bookmarks", "controller": "Pdf", "action": "Bookmarks", "childcount": "0"},
                                           { "id": "7", "name": "File Attachments", "controller": "Pdf", "action": "Attachments", "childcount": "0" },
										   { "id": "8", "name": "XFA Form Creation", "controller": "Pdf", "action": "XFAFormCreation", "childcount": "0" },
                                           { "id": "9", "name": "XFA Form Filling", "controller": "Pdf", "action": "XFAFormFilling", "childcount": "0" }]
                                              },
                                              {
                                                  "id": "10", "name": "Conformance", "controller": "Pdf", "action": "Conformance", "childcount": "1", "samples": [
                                           { "id": "1", "name": "PDF Conformance", "controller": "Pdf", "action": "Conformance", "childcount": "0" }]
                                              },                                                 
                                                       {
                                                           "id": "11", "name": "Modify Documents", "controller": "Pdf", "action": "MergeDocuments", "childcount": "1", "samples": [
                                           { "id": "1", "name": "Merge Documents", "controller": "Pdf", "action": "MergeDocuments", "childcount": "0" },
                                           { "id": "2", "name": "Split PDF", "controller": "Pdf", "action": "SplitPDF", "childcount": "0" },
                                           { "id": "3", "name": "Overlay Documents", "controller": "Pdf", "action": "OverlayDocuments", "childcount": "0" },
                                           { "id": "4", "name": "Booklet", "controller": "Pdf", "action": "Booklet", "childcount": "0" },
                                            { "id": "5", "name": "Import and Stamp", "controller": "Pdf", "action": "ImportAndStamp", "childcount": "0" },
                                           { "id": "6", "name": "Rearrange Pages", "controller": "Pdf", "action": "RearrangePages", "childcount": "0" }]

                                                       },
                                                         {
                                                             "id": "12", "name": "Accessibility", "controller": "Pdf", "action": "AutoTag", "childcount": "1", "samples": [
                                         { "id": "1", "name": "Autotag", "controller": "Pdf", "action": "AutoTag", "childcount": "0" },
										 { "id": "2", "name": "Customtag", "controller": "Pdf", "action": "CustomTag", "childcount": "0"  }
                                                             ]
                                                         }	                                                       
														 
         ]
     },
     {
         "name": "Presentation", "id": "Presentation", "childcount": "1", "Group": "FILE FORMATS", "controller": "Presentation", "action": "Default",
         "ugurl": "https://help.syncfusion.com/aspnet-core/presentation/overview",
         "forumurl": "https://www.syncfusion.com/forums/aspnetcore/presentation",
         "kburl": "https://www.syncfusion.com/kb/aspnetcore/presentation",
         "samples": [
			{
                 "id": "1", "name": "Getting Started", "controller": "Presentation", "action": "Getting Started", "childcount": "1", "samples": [
                     { "id": "1", "name": "Hello World", "controller": "Presentation", "action": "Default", "childcount": "0" }
                 ]
             },
			 {
                 "id": "2", "name": "Conversion", "controller": "Presentation", "action": "PPTXToImage", "childcount": "1", "samples": [
                     { "id": "1", "name": "PPTX To Image", "controller": "Presentation", "action": "PPTXToImage", "childcount": "0" },
                     { "id": "2", "name": "PPTX To PDF", "controller": "Presentation", "action": "PPTXToPDF", "childcount": "0" }
                 ]
             },
			 {
                 "id": "3", "name": "Slide Elements", "controller": "Presentation", "action": "Chart", "childcount": "1", "samples": [
                     
             { "id": "1", "name": "Chart", "controller": "Presentation", "action": "Chart", "childcount": "0" },
             { "id": "2", "name": "Slide", "controller": "Presentation", "action": "Slide", "childcount": "0" },
             { "id": "3", "name": "SmartArt", "controller": "Presentation", "action": "SmartArt", "childcount": "0" },
             { "id": "4", "name": "Table", "controller": "Presentation", "action": "Table", "childcount": "0" },
             { "id": "5", "name": "Comment", "controller": "Presentation", "action": "Comment", "childcount": "0" },
			 { "id": "6", "name": "Connector", "controller": "Presentation", "action": "Connector", "childcount": "0" }
                 ]
             },
			 {
                 "id": "4", "name": "Animation", "controller": "Presentation", "action": "CreateAnimation", "childcount": "1", "samples": [
                     { "id": "1", "name": "Create Animation", "controller": "Presentation", "action": "CreateAnimation", "childcount": "0"  },
			 { "id": "2", "name": "Modify Animation", "controller": "Presentation", "action": "ModifyAnimation", "childcount": "0"  }
                 ]
             },
			 {
                 "id": "5", "name": "Transition", "controller": "Presentation", "action": "SlideTransition", "childcount": "1", "samples": [
                     { "id": "1", "name": "Slide Transition", "controller": "Presentation", "action": "SlideTransition", "childcount": "0"  }
                 ]
             }
			 
         ]
     },
	 {
	     "name": "DocIO", "id": "DocIO", "childcount": "1", "Group": "FILE FORMATS", "controller": "DocIO", "type": "update", "action": "SalesInvoice", "samples": [
             {
                 "id": "1", "name": "Product Showcase", "controller": "DocIO", "action": "SalesInvoice", "childcount": "1", "samples": [
                     { "id": "1", "name": "Sales Invoice", "controller": "DocIO", "action": "SalesInvoice", "childcount": "0" },
                     { "id": "2", "name": "Update Fields", "controller": "DocIO", "action": "UpdateFields", "childcount": "0" }
                 ]
             },
             {
                 "id": "2", "name": "Getting Started", "controller": "DocIO", "action": "HelloWorld", "childcount": "1", "samples": [
                     { "id": "1", "name": "Hello World", "controller": "DocIO", "action": "HelloWorld", "childcount": "0" }
                 ]
             },
             {
                 "id": "3", "name": "Editing", "controller": "DocIO", "action": "FindandHighlight", "childcount": "1", "samples": [
                     { "id": "1", "name": "Find and Highlight", "controller": "DocIO", "action": "FindandHighlight", "childcount": "0" },
                     { "id": "2", "name": "Simple Replace", "controller": "DocIO", "action": "SimpleReplace", "childcount": "0" },
                     { "id": "3", "name": "Advanced Replace", "controller": "DocIO", "action": "AdvancedReplace", "childcount": "0" },
                     { "id": "4", "name": "Bookmark Contents", "controller": "DocIO", "action": "BookmarkNavigation", "childcount": "0" },
                     { "id": "5", "name": "Clone and Merge", "controller": "DocIO", "action": "CloneandMerge", "childcount": "0" },
                     { "id": "6", "name": "Forms", "controller": "DocIO", "action": "Forms", "childcount": "0" }
                 ]
             },
             {
                 "id": "4", "name": "Content Control", "controller": "DocIO", "action": "FormFillingAndProtection", "childcount": "1", "samples": [
                     { "id": "1", "name": "Form filling and Protection", "controller": "DocIO", "action": "FormFillingAndProtection", "childcount": "0" },
                     { "id": "2", "name": "XML mapping", "controller": "DocIO", "action": "XMLMapping", "childcount": "0" }
                 ]
             },
             {
                 "id": "5", "name": "Insert Content", "controller": "DocIO", "action": "Bookmarks", "childcount": "1", "samples": [
                     { "id": "1", "name": "Bookmarks", "controller": "DocIO", "action": "Bookmarks", "childcount": "0" },
                     { "id": "2", "name": "Header and Footer", "controller": "DocIO", "action": "HeaderandFooter", "childcount": "0" },
                     { "id": "3", "name": "Image Insertion", "controller": "DocIO", "action": "ImageInsertion", "childcount": "0" },
                     { "id": "4", "name": "Insert OLE Object", "controller": "DocIO", "action": "InsertOLEObject", "childcount": "0" }
                 ]
             },
             {
                 "id": "6", "name": "Formatting", "controller": "DocIO", "action": "FormatTable", "childcount": "1", "samples": [
                     { "id": "1", "name": "Format Table", "controller": "DocIO", "action": "FormatTable", "childcount": "0" },
                     { "id": "2", "name": "Format Text", "controller": "DocIO", "action": "FormatText", "childcount": "0" },
                     { "id": "3", "name": "RTL Support", "controller": "DocIO", "action": "RTLSupport", "childcount": "0" },
                     { "id": "4", "name": "Styles", "controller": "DocIO", "action": "Styles", "childcount": "0" },
                     { "id": "5", "name": "Table Styles", "controller": "DocIO", "action": "TableStyles", "childcount": "0", "type": "update" }
                 ]
             },
             {
                 "id": "7", "name": "Mail Merge", "controller": "DocIO", "action": "EmployeeReport", "childcount": "1", "samples": [
                     { "id": "1", "name": "Employee Report", "controller": "DocIO", "action": "EmployeeReport", "childcount": "0" },
                     { "id": "2", "name": "Mail Merge Event", "controller": "DocIO", "action": "MailMergeEvent", "childcount": "0" },
                     { "id": "3", "name": "Nested Mail Merge", "controller": "DocIO", "action": "NestedMailMerge", "childcount": "0" }
                 ]
             },
             {
                 "id": "8", "name": "Import and Export", "controller": "DocIO", "action": "WordToPDF", "childcount": "1", "samples": [
				 { "id": "1", "name": "Word To PDF", "controller": "DocIO", "action": "WordToPDF", "childcount": "0", "type": "update" },
                     { "id": "2", "name": "Word to WordML", "controller": "DocIO", "action": "WordToWordML", "childcount": "0" },
                     { "id": "3", "name": "WordML to Word", "controller": "DocIO", "action": "WordMLToWord", "childcount": "0" },
                     { "id": "4", "name": "RTF to Word", "controller": "DocIO", "action": "RTFToDoc", "childcount": "0" },
                     { "id": "5", "name": "Word to ODT", "controller": "DocIO", "action": "DOCtoODT", "childcount": "0" }
                 ]
             },
             {
                 "id": "9", "name": "Page Layout", "controller": "DocIO", "action": "InsertBreak", "childcount": "1", "samples": [
                     { "id": "1", "name": "Insert Break", "controller": "DocIO", "action": "InsertBreak", "childcount": "0" },
                     { "id": "2", "name": "Watermark", "controller": "DocIO", "action": "Watermark", "childcount": "0" }
                 ]
             },
             {
                 "id": "10", "name": "References", "controller": "DocIO", "action": "FootnotesandEndnotes", "childcount": "1", "samples": [
                     { "id": "1", "name": "Footnotes and Endnotes", "controller": "DocIO", "action": "FootnotesandEndnotes", "childcount": "0" },
                 ]
             },
             {
                 "id": "11", "name": "Shapes", "controller": "DocIO", "action": "AutoShapes", "childcount": "1", "samples": [
                     { "id": "1", "name": "AutoShapes", "controller": "DocIO", "action": "AutoShapes", "childcount": "0" }
                 ]
             },
             {
                 "id": "12", "name": "Chart", "controller": "DocIO", "action": "PieChart", "childcount": "1", "samples": [
                     { "id": "1", "name": "Pie Chart", "controller": "DocIO", "action": "PieChart", "childcount": "0" },
                     { "id": "2", "name": "Bar Chart", "controller": "DocIO", "action": "BarChart", "childcount": "0" }
                 ]
             },
             {
                 "id": "13", "name": "View", "controller": "DocIO", "action": "DocumentSettings", "childcount": "1", "samples": [
                     { "id": "1", "name": "Document Settings", "controller": "DocIO", "action": "DocumentSettings", "childcount": "0" },
                     { "id": "2", "name": "Macro Preservation", "controller": "DocIO", "action": "MacroPreservation", "childcount": "0" }
                 ]
             },
             {
                 "id": "14", "name": "Security", "controller": "DocIO", "action": "DocumentProtection", "childcount": "1", "samples": [
                     { "id": "1", "name": "Document Protection", "controller": "DocIO", "action": "DocumentProtection", "childcount": "0" },
                 ]
             }
         ]         
	 },
		 {
		     "name": "XlsIO", "id": "XlsIO", "childcount": "1", "Group": "FILE FORMATS", "controller": "XlsIO", "type": "update", "action": "Create", "samples": [
				 {
                "id": "1", "name": "GETTING STARTED", "controller": "XlsIO", "action": "Create", "childcount": "1",  "samples": [
                    { "id": "1", "name": "Create", "controller": "XlsIO", "action": "Create", "childcount": "0", "isResponsive": "false"}
                ]
                 },
				 {
                     "id": "2", "name": "PRODUCT SHOWCASE", "controller": "XlsIO", "action": "AttendanceTracker", "childcount": "1", "samples": [
                         { "id": "1", "name": "Attendance Tracker", "controller": "XlsIO", "action": "AttendanceTracker", "childcount": "0" }
                     ]
                 },
                 {
                     "id": "3", "name": "FORMATTING", "controller": "XlsIO", "action": "FormatCells", "childcount": "1", "samples": [
                         { "id": "1", "name": "Format Cells", "controller": "XlsIO", "action": "FormatCells", "childcount": "0" },
                         { "id": "2", "name": "Conditional Formatting", "controller": "XlsIO", "action": "ConditionalFormatting", "childcount": "0" }
                     ]
                 },
				 {
                "id": "4", "name": "CHARTS", "controller": "XlsIO", "action": "ChartWorksheet", "childcount": "1",  "samples": [
                    { "id": "1", "name": "Chart Worksheet", "controller": "XlsIO", "action": "ChartWorksheet", "childcount": "0" },
                    { "id": "2", "name": "Embedded Chart", "controller": "XlsIO", "action": "EmbeddedChart", "childcount": "0" },
                    { "id": "3", "name": "Sparklines", "controller": "XlsIO", "action": "Sparklines", "childcount": "0" }
                ]
                 },
                 {
                     "id": "5", "name": "FORMULAS", "controller": "XlsIO", "action": "Formulas", "childcount": "1", "samples": [
                         { "id": "1", "name": "Formulas", "controller": "XlsIO", "action": "Formulas", "childcount": "0", "isResponsive": "false" }
                     ]
                 },                 
                 {
                     "id": "6", "name": "DATA MANAGEMENT", "controller": "XlsIO", "action": "DataValidation", "childcount": "1", "samples": [
                         { "id": "1", "name": "Data Validation", "controller": "XlsIO", "action": "DataValidation", "childcount": "0" },
                         { "id": "2", "name": "Data Sorting", "controller": "XlsIO", "action": "DataSorting", "childcount": "0" },
                         { "id": "3", "name": "Form Controls", "controller": "XlsIO", "action": "FormControls", "childcount": "0" },
                         { "id": "4", "name": "Filters", "controller": "XlsIO", "action": "AutoFilter", "childcount": "0" },
						 { "id": "5", "name": "Performance", "controller": "XlsIO", "action": "Performance", "childcount": "0", "type":"new" }

                     ]
                 },
                 {
                     "id": "7", "name": "DATA BINDING", "controller": "XlsIO", "action": "CollectionObjects", "childcount": "1", "samples": [
                         { "id": "1", "name": "Collection Objects", "controller": "XlsIO", "action": "CollectionObjects", "type": "update", "childcount": "0" },
                         { "id": "2", "name": "DataTable", "controller": "XlsIO", "action": "DataTable", "childcount": "0"},
						 { "id": "3", "name": "Import Nested Collection", "controller": "XlsIO", "action": "ImportNestedCollection", "type": "new", "childcount": "0" }
                     ]
                 },
				 {
                     "id": "8", "name": "Export", "controller": "XlsIO", "action": "ExcelToPDF", "childcount": "1", samples: [
                         { "id": "1", "name": "Excel To PDF", "controller": "XlsIO", "action": "ExcelToPDF","childcount": "0", "type": "update"},
						 { "id": "2", "name": "Worksheet To Image", "controller": "XlsIO", "action": "WorksheetToImage","childcount": "0" },
						 { "id": "3", "name": "Worksheet To HTML", "controller": "XlsIO", "action": "WorksheetToHTML","childcount": "0" }
                     ]
                 },
                 {
                     "id": "9", "name": "SETTINGS", "controller": "XlsIO", "action": "EncryptAndDecrypt", "childcount": "1", "samples": [
                         { "id": "1", "name": "Encrypt and Decrypt", "controller": "XlsIO", "action": "EncryptAndDecrypt", "childcount": "0" }
                     ]
                 },
                 {
                     "id": "10", "name": "BUSINESS INTELLIGENCE", "controller": "XlsIO", "action": "Tables", "childcount": "1", "samples": [
                         { "id": "1", "name": "Tables", "controller": "XlsIO", "action": "Tables", "childcount": "0" }
                     ]
                 },
                 {
                     "id": "11", "name": "SHAPES", "controller": "XlsIO", "action": "AutoShapes", "childcount": "1", "samples": [
                         { "id": "1", "name": "AutoShapes", "controller": "XlsIO", "action": "AutoShapes", "childcount": "0" },
						 { "id": "2", "name": "GroupShapes", "controller": "XlsIO", "action": "GroupShapes", "childcount": "0" }
                     ]
                 },
		     ]
		 },
         {
             "name": "PivotGrid", "id": "PivotGrid", "type": "preview", "childcount": "1", "Group": "BUSINESS INTELLIGENCE", "controller": "PivotGrid", "action": "Default", "samples": [
                 { "id": "1", "name": "Default", "controller": "PivotGrid", "action": "Default", "childcount": "0" },
                 { "id": "2", "name": "Olap", "controller": "PivotGrid", "action": "Olap", "childcount": "0" },
                 { "id": "3", "name": "User Interaction", "controller": "PivotGrid", "action": "UserInteraction", "childcount": "0" }
             ]
         }];
