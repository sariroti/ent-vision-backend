# ent-vision-backend
using EF6 Code First

## API
### Product
```
GET
/api/products

GET
/api/products?columName=categoryName&value=Beverages

```
### Order
```
POST
/api/orders

request body example :

{
    "order": {
        "RequiredDate": "datetime",
        "ShipName": "String",
        "ShipAddress": "a",
        "ShipCity": "String",
        "ShipPostalCode": "String",
        "ShipCountry": "String",
        "CustomerID": "String",
        "orderDetails": [
            {
                "PartNumber": "String", 
                "Quantity": "Int"
            },
            {
                "PartNumber": "String", 
                "Quantity": "Int"
            }
        ]
    }
}
```

### Chart 

```
GET
/api/charts/GetProductTotalByCategories
```

### command line after cloning to generate migrations and create db in your local

```
Enable-Migrations
Add-Migration
Update-Database
```

