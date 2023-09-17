import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';


@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent {

  public eventos: any = [];
  withImagem: number = 150;
  marginImagem: number = 2;
  statusImagem: boolean = true;
  filtroBuscar: string = '';

  constructor( private http: HttpClient ) { }
  ngOnInit(): void{
    this.getEventos();
  }

  public alterarImagem(): void{
    this.statusImagem = !this.statusImagem;
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/api/Eventos').subscribe(
      response => this.eventos = response,
      error => console.log(error),
    );
  }

}
