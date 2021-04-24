export class orders
{
    public OrderID:number; 
    public CustomerID?:string;
    public EmployeeID?:number;
    public OrderDate?:Date=new Date();
    public RequiredDate?:Date=new Date();
    public ShippedDate:Date=new Date();
    public ShipVia?:number;
    public Freight?:number;
    public ShipName?:string;
    public ShipAddress:string;
    public ShipCity:string;
    public ShipRegion:string;
    public ShipPostalCode:string;
    public ShipCountry:string;
}