# Miniproject2
This is a console application that allows users to enter and manage a list of products. The user can input the category, product name, and price for each product. The application validates the input and provides feedback to the user. At the end, it displays the list of products sorted by price and calculates the total amount.

Usage
Run the application.
Follow the prompts to enter the category, product name, and price for each product.
To quit entering products, type 'Q' when prompted for the category, product name, or price.
The application will display the list of products sorted by price and the total amount.

Instructions
Initialize an empty list to store the products.
Prompt the user to enter the category, product name, and price for each product.
Validate the input:
If the user enters 'Q', exit the loop.
If the category or product name is empty, display an error message and continue to the next iteration.
If the price is not a valid numeric value, display an error message and continue to the next iteration.
If the input is valid, create a Product object and add it to the list.
Display a success message if the product is added successfully, or an error message if the price is invalid.
Display the header for the product list.
Sort the list of products by price.
Iterate over the sorted list and display each product's category, product name, and price.
Calculate and display the total amount of all products.
End the program.

Classes
Product
Properties:
Category: The category of the product.
ProductName: The name of the product.
Price: The price of the product.
