export class Employees
{
    public EmployeeID:number;
    public LastName:string;
    public FirstName:string;
    public Title?:string;
    public TitleOfCourtesy?:string;
    public BirthDate?:Date=new Date();
    public HireDate?:Date=new Date();
    public Address?:string;
    public City?:string;
    public Region?:string;
    public PostalCode?:string;
    public Country?:string;
    public HomePhone?:string;
    public Extension?:string;
    public Photo?: HTMLImageElement
    public Notes?:string;
    public ReportsTo?:string;
    public PhotoPath?:string;
}