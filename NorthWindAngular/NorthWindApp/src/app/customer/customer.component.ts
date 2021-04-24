import {Component, OnInit, Directive,Input,Output,QueryList,ViewChildren,EventEmitter} from  '@angular/core';
import { CustomerService } from '../shared/services/customer.service';
import { Customer } from '../shared/model/customer.model';
import {NgbModal} from '@ng-bootstrap/ng-bootstrap'
//import { type } from 'os';
import  {CustomerAddOrEditComponent}from './customer.addoredit.component'

export type SortColumn= keyof Customer|'';
export type SortDirection='asc'|'desc'|'';
const rotate:{[key:string]:SortDirection}={ 'asc': 'desc', 'desc': '', '': 'asc' };
const compare=(v1:string,v2:string)=>v1<v2?-1:v1>v2?1:0;



export interface SortEvent
{
    column:SortColumn;
    direction:SortDirection;
}

@Directive({
    selector:'th[sortable]',
    host:{
        '[class.asc]': 'direction === "asc"',
        '[class.desc]': 'direction === "desc"',
        '(click)': 'rotate()'
    }
})
export class NgbdSortableHeader{
    @Input() sortable:SortColumn='';
    @Input() direction:SortDirection='';
    @Output() sort=new EventEmitter<SortEvent>();
    rotate() {
        this.direction = rotate[this.direction];
        this.sort.emit({column: this.sortable, direction: this.direction});
      }
}

@Component({
    templateUrl:'./customer.component.html',
    styleUrls:['./customer.component.css']
})
export class CustomerComponent implements OnInit
{
    customersData:Customer[];
    errorMessage:string;
    collectionSize:number;
    page:number = 1;
    pageSize:number = 10;
    selectedRow:number;
    selectedCustomerID:string;
    custometlength:number=0;
    selectedCustomer:Customer

    @ViewChildren(NgbdSortableHeader) headers: QueryList<NgbdSortableHeader>;

    //Search variables
    CustName: string="";
    CustCity:string="";
    CustCountry:string="";
    constructor(private customerService:CustomerService,public modalService:NgbModal)
    {

    }
    ngOnInit():void
    {
        this.GetData()
    }

    GetData()
    {
      this.customerService.GetCustormers()
      .subscribe(customers=>{
          this.customersData=customers;
          //this.customersData=[];
          this.collectionSize = customers.length>0?this.customersData.length:0;
         
      }) ;
    }
    get customers():Customer[]
    {
       return  this.customersData ?  this.customersData.map((customer,i)=>({id:i+1,...customer}))
        .slice((this.page-1)*this.pageSize,(this.page-1)*this.pageSize+this.pageSize):this.customersData;
    }
    public setSelectedRow(event: any, cust: Customer)
    {
      this.selectedCustomer=cust;
        this.selectedCustomerID=cust.CustomerID;  
    }

    // public setSelectedRow(index:number)
    // {
    //     this.selectedRow=index;
    // }
    onSort({column, direction}: SortEvent) {

        // resetting other headers
        this.headers.forEach(header => {
          if (header.sortable !== column) {
            header.direction = '';
          }
        });
    
        // sorting countries
        if (direction === '' || column === '') {
          this.customersData = this.customersData;
          this.customersData = this.customersData;
        } else {
          this.customersData = [...this.customersData].sort((a, b) => {
            const res = compare(`${a[column]}`, `${b[column]}`);
            return direction === 'asc' ? res : -res;
          });
        }
      }

    public Search()
    {
      var searchFilter:any={};
      searchFilter.CompanyName=this.CustName;
      searchFilter.City=this.CustCity;
      searchFilter.Country=this.CustCountry;
      this.customersData=[];

      this.customerService.GetCustormersByParams(searchFilter)
        .subscribe(customers => {
          this.customersData=[];
          this.customersData=customers;
          this.collectionSize = this.customersData.length;
         
      }) ;
    }
    public OnUpdate()
    {
      const  modalRef=this.modalService.open(CustomerAddOrEditComponent,{size: 'xl',centered:true})
      modalRef.componentInstance.selectedCustomer=this.selectedCustomer;
    }
}