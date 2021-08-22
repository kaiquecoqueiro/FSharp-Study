type VendorSale = 
    { Id: string 
      PartId: string 
      UnitPrice: double 
      Quantity: int }      

let vendors = 
    [ { Id = "1"
        PartId = "1"
        UnitPrice = 23.80
        Quantity = 3 }
      { Id = "2"
        PartId = "2"
        UnitPrice = 3.50
        Quantity = 5 }
      { Id = "3"
        PartId = "3"
        UnitPrice = 9.40
        Quantity = 2 } ]        

let totalAmount price quantity = price * (double)quantity

let vendorsTotalComissions = 
    vendors
    |> List.map
        (fun vendor ->
            let comissionRate = 0.05

            {| Code = vendor.Id
               Comission = (totalAmount vendor.UnitPrice vendor.Quantity) * comissionRate |}) // Calculate comission

vendorsTotalComissions
|> List.iter (fun vendor -> printfn "Vendedor: %s recebeu de comissao: R$ %.2f." vendor.Code vendor.Comission)