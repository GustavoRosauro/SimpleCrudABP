import { ListService, PagedResultDto } from '@abp/ng.core'
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PersonService, PersonDto } from '@proxy/person';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';



@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.scss'],
  providers: [ListService],
})
export class PersonComponent implements OnInit {
  form: FormGroup;
  isModalOpen = false;
  person = { items: [], totalCount: 0 } as PagedResultDto<PersonDto>;
  constructor(public readonly list: ListService,
     private personService: PersonService,
     private fb:FormBuilder,
     private confirmation: ConfirmationService) {
  }

  ngOnInit(): void {    
    const personStreamDecorator = (query) => this.personService.getList(query);
    this.list.hookToQuery(personStreamDecorator).subscribe((response) => {
      console.log(response);
      this.person = response
    })
  }
  createPerson():void{
    this.buildForm();
    this.isModalOpen = true;
  }
  buildForm():void{
    this.form = this.fb.group({
      name:['',Validators.required],
      email:['null',Validators.required],
      idade:[null,Validators.required]
    });
  }
  save(){
    if(this.form.invalid){
      return;
    }
    this.personService.create(this.form.value).subscribe(()=>{
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    })
  }
  delete(id:string){
    this.confirmation.warn("::AreYouSureToDelete",'::AreYouSure').subscribe((status)=>{
      console.log(status)
      if(status == Confirmation.Status.confirm){
        this.personService.delete(id).subscribe(()=>this.list.get())
      }
    })
  }
}
