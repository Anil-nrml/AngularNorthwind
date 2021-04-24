import {Component,OnInit} from  '@angular/core'
import {NgbActiveModal} from '@ng-bootstrap/ng-bootstrap'
import {FormControl} from '@angular/forms' 

import { Customer } from '../shared/model/customer.model'
@Component({
    templateUrl:'./customer.reactforms.addoredit.component.html',
    
})
export class CustomerAddOrEditComponent implements OnInit
{
    public selectedCustomer:Customer
    CompanyName=new FormControl('')
    ContactTitle=new FormControl('')
    ContactName=new FormControl('')
    Address=new FormControl('')
    City=new FormControl('')
    Region=new FormControl('')
    Country=new FormControl('')
    Phone=new FormControl('')
    Fax=new FormControl('')
    constructor(public activeModal:NgbActiveModal)
    {

    }
    ngOnInit()
    {
        this.CompanyName.setValue(this.selectedCustomer.CompanyName)
        this.ContactTitle.setValue(this.selectedCustomer.ContactTitle)
        this.ContactName.setValue(this.selectedCustomer.ContactName)
        this.Address.setValue(this.selectedCustomer.Address)
        this.City.setValue(this.selectedCustomer.City)
        this.Region.setValue(this.selectedCustomer.Region)
        this.Country.setValue(this.selectedCustomer.Country)
        this.Phone.setValue(this.selectedCustomer.Phone)
        this.Fax.setValue(this.selectedCustomer.Fax)
    }

    OnClose()
    {
        
        this.activeModal.close(null)
    }
}