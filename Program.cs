

// Initialize the Google Sheets service with credentials and spreadsheet ID
var sheetsService = new GenericGoogleSheetsService(Constant.SecretKey, Constant.SpreadsheetId);


// CREATE operation: Add a new product to the Google Sheet
var newProduct = new Product
{
    Name = "Wireless Mouse",
    Price = 29.99m,
    Category = "Electronics",
    Tags = new List<string> { "Wireless", "Ergonomic" },
    CreatedDate = DateTime.Now,
    IsActive = true
};


Product productCreated = await sheetsService.AddAsync(newProduct,"Product");


// Store the created product (added to default sheet)
var createdProduct = productCreated;



// READ operation: Retrieve all products from the specified sheet
var allProducts = await sheetsService.GetAllAsync<Product>("Product");


// Display all retrieved products
foreach (var product in allProducts)
{
    Console.WriteLine($"Product: {product.Name}, Price: {product.Price:C}");
    Console.WriteLine($"Tags: {string.Join(", ", product.Tags)}");
}


// Find the product to update (by name)
var productToUpdate = allProducts.FirstOrDefault(p => p.Name == "Wireless Mouse");


// UPDATE operation: Modify the product if found
if (productToUpdate != null)
{
    productToUpdate.Price = 400.00m; 
    productToUpdate.Tags.Add("Sale");
    
    var success = await sheetsService.UpdateAsync(productToUpdate,"Product");
    
    if (success)
    {
        Console.WriteLine("Product updated successfully!");
    }
}


// DELETE operation: Remove a product by ID from the specified sheet
var deleteSuccess = await sheetsService.DeleteAsync("49437db4-43ba-42be-94cf-cee109208983", "Product");


if (deleteSuccess)
{
    Console.WriteLine("Product deleted successfully!");
}
