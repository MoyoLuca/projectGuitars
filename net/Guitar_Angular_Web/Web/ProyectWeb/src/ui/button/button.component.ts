import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'ui-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.scss'],
})
export class ButtonComponent {

  @Input() text: string = '';
  @Output() textChange = new  EventEmitter<string>();

  @Output() onClick = new EventEmitter<any>();


  click(){
    this.onClick.emit();
  }


  ngOnChanges(){
    console.log(`cambiando ${this.text}`)

    this.text = `$${this.text}`
  }

}
