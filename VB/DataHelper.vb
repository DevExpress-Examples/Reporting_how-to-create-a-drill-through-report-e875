Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DrillThroughReport
	Public Class DataHelper
		Public Shared Function GetCategories() As DataTable
			Dim table As New DataTable()

			Dim idColumn As DataColumn = table.Columns.Add("CategoryID", GetType(Integer))
			table.Columns.Add("CategoryName", GetType(String))
			table.Columns.Add("Description", GetType(String))
			table.PrimaryKey = New DataColumn() { idColumn }

			table.Rows.Add(New Object() { 1, "Beverages", "Soft drinks, coffees, teas, beers, and ales" })
			table.Rows.Add(New Object() { 2, "Condiments", "Sweet and savory sauces, relishes, spreads, and seasonings" })
			table.Rows.Add(New Object() { 3, "Confections", "Desserts, candies, and sweet breads" })
			table.Rows.Add(New Object() { 4, "Dairy Products", "Cheeses" })
			table.Rows.Add(New Object() { 5, "Grains/Cereals", "Breads, crackers, pasta, and cereal" })
			table.Rows.Add(New Object() { 6, "Meat/Poultry", "Prepared meats" })
			table.Rows.Add(New Object() { 7, "Produce", "Dried fruit and bean curd" })
			table.Rows.Add(New Object() { 8, "Seafood", "Seaweed, frutti di mare and fish" })
			table.AcceptChanges()
			Return table
		End Function

		Public Shared Function GetProducts() As DataTable
			Dim table As New DataTable()

			Dim idColumn As DataColumn = table.Columns.Add("ProductID", GetType(Integer))
			table.Columns.Add("CategoryID", GetType(Integer))
			table.Columns.Add("ProductName", GetType(String))
			table.Columns.Add("QuantityPerUnit", GetType(String))
			table.Columns.Add("UnitsInStock", GetType(Integer))
			table.Columns.Add("UnitPrice", GetType(Single))
			table.PrimaryKey = New DataColumn() { idColumn }

			table.Rows.Add(New Object() { 1, 1, "Chai", "10 boxes x 20 bags", 39,18 })
			table.Rows.Add(New Object() { 2, 1, "Chang", "24 - 12 oz bottles", 17, 19 })
			table.Rows.Add(New Object() { 3, 2, "Aniseed Syrup", "12 - 550 ml bottles", 13, 10 })
			table.Rows.Add(New Object() { 4, 2, "Chef Anton's Cajun Seasoning", "48 - 6 oz jars", 53, 22 })
			table.Rows.Add(New Object() { 5, 2, "Chef Anton's Gumbo Mix", "36 boxes", 0, 21.4 })
			table.Rows.Add(New Object() { 6, 2, "Grandma's Boysenberry Spread", "12 - 8 oz jars", 120, 25 })
			table.Rows.Add(New Object() { 7, 7, "Uncle Bob's Organic Dried Pears", "12 - 1 lb pkgs.", 15, 30 })
			table.Rows.Add(New Object() { 8, 2, "Northwoods Cranberry Sauce", "12 - 12 oz jars", 6, 40 })
			table.Rows.Add(New Object() { 9, 6, "Mishi Kobe Niku", "18 - 500 g pkgs.", 29, 97 })
			table.Rows.Add(New Object() { 10, 8, "Ikura", "12 - 200 ml jars", 31,31 })
			table.Rows.Add(New Object() { 11, 4, "Queso Cabrales", "1 kg pkg.", 22,21 })
			table.Rows.Add(New Object() { 12, 4, "Queso Manchego La Pastora", "10 - 500 g pkgs.", 86,38 })
			table.Rows.Add(New Object() { 13, 8, "Konbu", "2 kg box", 24,6 })
			table.Rows.Add(New Object() { 14, 7, "Tofu", "40 - 100 g pkgs.", 35,23.3 })
			table.Rows.Add(New Object() { 15, 2, "Genen Shouyu", "24 - 250 ml bottles", 39,15.5 })
			table.Rows.Add(New Object() { 16, 3, "Pavlova", "32 - 500 g boxes", 29,17.5 })
			table.Rows.Add(New Object() { 17, 6, "Alice Mutton", "20 - 1 kg tins", 0,39 })
			table.Rows.Add(New Object() { 18, 8, "Carnarvon Tigers", "16 kg pkg.", 42,62.5 })
			table.Rows.Add(New Object() { 19, 3, "Teatime Chocolate Biscuits", "10 boxes x 12 pieces", 25,9.2 })
			table.Rows.Add(New Object() { 20, 3, "Sir Rodney's Marmalade", "30 gift boxes", 40,81 })
			table.Rows.Add(New Object() { 21, 3, "Sir Rodney's Scones", "24 pkgs. x 4 pieces", 3,10 })
			table.Rows.Add(New Object() { 22, 5, "Gustaf's Knackebrod", "24 - 500 g pkgs.", 104,21 })
			table.Rows.Add(New Object() { 23, 5, "Tunnbrod", "12 - 250 g pkgs.", 61,9 })
			table.Rows.Add(New Object() { 24, 1, "Guarana Fantastica", "12 - 355 ml cans", 20,4.5 })
			table.Rows.Add(New Object() { 25, 3, "NuNuCa Nu?-Nougat-Creme", "20 - 450 g glasses", 76,14 })
			table.Rows.Add(New Object() { 26, 3, "Gumbar Gummibarchen", "100 - 250 g bags", 15,31.2 })
			table.Rows.Add(New Object() { 27, 3, "Schoggi Schokolade", "100 - 100 g pieces", 49,43.9 })
			table.Rows.Add(New Object() { 28, 7, "Rossle Sauerkraut", "25 - 825 g cans", 26,45.6 })
			table.Rows.Add(New Object() { 29, 6, "Thuringer Rostbratwurst", "50 bags x 30 sausgs.", 0,124 })
			table.Rows.Add(New Object() { 30, 8, "Nord-Ost Matjeshering", "10 - 200 g glasses", 10,25.9 })
			table.Rows.Add(New Object() { 31, 4, "Gorgonzola Telino", "12 - 100 g pkgs", 0,12.5 })
			table.Rows.Add(New Object() { 32, 4, "Mascarpone Fabioli", "24 - 200 g pkgs.", 9,32 })
			table.Rows.Add(New Object() { 33, 4, "Geitost", "500 g", 112,2.5 })
			table.Rows.Add(New Object() { 34, 1, "Sasquatch Ale", "24 - 12 oz bottles", 111,14 })
			table.Rows.Add(New Object() { 35, 1, "Steeleye Stout", "24 - 12 oz bottles", 20,18 })
			table.Rows.Add(New Object() { 36, 8, "Inlagd Sill", "24 - 250 g  jars", 112,19 })
			table.Rows.Add(New Object() { 37, 8, "Gravad lax", "12 - 500 g pkgs.", 11,26 })
			table.Rows.Add(New Object() { 38, 1, "Cote de Blaye", "12 - 75 cl bottles", 17,264 })
			table.Rows.Add(New Object() { 39, 1, "Chartreuse verte", "750 cc per bottle", 69,18 })
			table.Rows.Add(New Object() { 40, 8, "Boston Crab Meat", "24 - 4 oz tins", 123,18.4 })
			table.Rows.Add(New Object() { 41, 8, "Jack's New England Clam Chowder", "12 - 12 oz cans", 85,9.65 })
			table.Rows.Add(New Object() { 42, 5, "Singaporean Hokkien Fried Mee", "32 - 1 kg pkgs.", 26,14 })
			table.Rows.Add(New Object() { 43, 1, "Ipoh Coffee", "16 - 500 g tins", 17,46 })
			table.Rows.Add(New Object() { 44, 2, "Gula Malacca", "20 - 2 kg bags", 27,19.5 })
			table.Rows.Add(New Object() { 45, 8, "Rogede sild", "1k pkg.", 5,9.5 })
			table.Rows.Add(New Object() { 46, 8, "Spegesild", "4 - 450 g glasses", 95,12 })
			table.Rows.Add(New Object() { 47, 3, "Zaanse koeken", "10 - 4 oz boxes", 36,9.5 })
			table.Rows.Add(New Object() { 48, 3, "Chocolade", "10 pkgs.", 15,12.8 })
			table.Rows.Add(New Object() { 49, 3, "Maxilaku", "24 - 50 g pkgs.", 10,20 })
			table.Rows.Add(New Object() { 50, 3, "Valkoinen suklaa", "12 - 100 g bars", 65,16.3 })
			table.Rows.Add(New Object() { 51, 7, "Manjimup Dried Apples", "50 - 300 g pkgs.", 20,53 })
			table.Rows.Add(New Object() { 52, 5, "Filo Mix", "16 - 2 kg boxes", 38,7 })
			table.Rows.Add(New Object() { 53, 6, "Perth Pasties", "48 pieces", 0,32.8 })
			table.Rows.Add(New Object() { 54, 6, "Tourtiere", "16 pies", 21,7.45 })
			table.Rows.Add(New Object() { 55, 6, "Pate chinois", "24 boxes x 2 pies", 115,24 })
			table.Rows.Add(New Object() { 56, 5, "Gnocchi di nonna Alice", "24 - 250 g pkgs.", 21,38 })
			table.Rows.Add(New Object() { 57, 5, "Ravioli Angelo", "24 - 250 g pkgs.", 36,19.5 })
			table.Rows.Add(New Object() { 58, 8, "Escargots de Bourgogne", "24 pieces", 62,13.3 })
			table.Rows.Add(New Object() { 59, 4, "Raclette Courdavault", "5 kg pkg.", 79,55 })
			table.Rows.Add(New Object() { 60, 4, "Camembert Pierrot", "15 - 300 g rounds", 19,34 })
			table.Rows.Add(New Object() { 61, 2, "Sirop d'erable", "24 - 500 ml bottles", 113,28.5 })
			table.Rows.Add(New Object() { 62, 3, "Tarte au sucre", "48 pies", 17,49.3 })
			table.Rows.Add(New Object() { 63, 2, "Vegie-spread", "15 - 625 g jars", 24,43.9 })
			table.Rows.Add(New Object() { 64, 5, "Wimmers gute Semmelknodel", "20 bags x 4 pieces", 22,33.3 })
			table.Rows.Add(New Object() { 65, 2, "Louisiana Fiery Hot Pepper Sauce", "32 - 8 oz bottles", 76,21.1 })
			table.Rows.Add(New Object() { 66, 2, "Louisiana Hot Spiced Okra", "24 - 8 oz jars", 4,17 })
			table.Rows.Add(New Object() { 67, 1, "Laughing Lumberjack Lager", "24 - 12 oz bottles", 52,14 })
			table.Rows.Add(New Object() { 68, 3, "Scottish Longbreads", "10 boxes x 8 pieces", 6,12.5 })
			table.Rows.Add(New Object() { 69, 4, "Gudbrandsdalsost", "10 kg pkg.", 26,36 })
			table.Rows.Add(New Object() { 70, 1, "Outback Lager", "24 - 355 ml bottles", 15,15 })
			table.Rows.Add(New Object() { 71, 4, "Flotemysost", "10 - 500 g pkgs.", 26,21.5 })
			table.Rows.Add(New Object() { 72, 4, "Mozzarella di Giovanni", "24 - 200 g pkgs.", 14,34.8 })
			table.Rows.Add(New Object() { 73, 8, "Rod Kaviar", "24 - 150 g jars", 101,15 })
			table.Rows.Add(New Object() { 74, 7, "Longlife Tofu", "5 kg pkg.", 4,10 })
			table.Rows.Add(New Object() { 75, 1, "Rhonbrau Klosterbier", "24 - 0.5 l bottles", 125,7.75 })
			table.Rows.Add(New Object() { 76, 1, "Lakkalikoori", "500 ml", 57,18 })
			table.Rows.Add(New Object() { 77, 2, "Original Frankfurter grune So?e", "12 boxes", 32,13 })
			table.AcceptChanges()
			Return table
		End Function
	End Class
End Namespace
