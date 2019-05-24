# ent-vision-backend

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
