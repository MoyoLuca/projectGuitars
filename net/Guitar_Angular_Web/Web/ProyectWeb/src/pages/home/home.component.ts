import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { GuitarServicesModule } from '@guitangweb/services.module';
import { UsersService } from '@guitangweb/users.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  //Flags
  showOrHide = false;

  //FormGrops
  formGroup = new FormGroup({
    textInput: new FormControl(undefined, [Validators.required]),

  });

  //Arrays
  arrayNomrbres: string[] = ['Texto 1', 'Texto 2', 'Texto 3'];
  arrayObjetos: any[] = [{ Name: 'Oscar obj' }, { Name: 'Miguel obj' }];

  constructor(public router: Router,public userService:UsersService) {}

  navigate() {
    this.router.navigate(['/contact']);
  }

  toggleShow() {
    this.showOrHide = !this.showOrHide;
  }

  showAlert() {
    // alert('Fui clickeado')
  }

  //Getters

  get textInput() {
    return this.formGroup.controls.textInput.value;
  }
}
