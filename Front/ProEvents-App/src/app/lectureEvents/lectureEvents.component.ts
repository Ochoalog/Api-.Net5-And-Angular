import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './lectureEvents.component.html',
  styleUrls: ['./lectureEvents.component.scss']
})
export class EventsComponent implements OnInit {

  public events: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEvents();
  }

  public getEvents(): void {
    this.http.get('https://localhost:5001/api/events').subscribe(
      response => this.events = response,
      error => console.log(error)
    );
  }
}
