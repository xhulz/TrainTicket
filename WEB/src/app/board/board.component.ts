import { Component, OnInit } from '@angular/core';
import { KEYBOARD } from '../shared/util.data';
import { StationService } from '../services/station.service';
import { StationModel } from '../models/station.model';

@Component({
  selector: 'app-board',
  templateUrl: './board.component.html',
  styleUrls: ['./board.component.css']  
})
export class BoardComponent implements OnInit {

  keyboard: any[] = KEYBOARD
  userInput: string = ""
  stations: StationModel[] = []
  filteredStations: StationModel[] = []
  nextKeys: string[] = []

  constructor(private stationService: StationService) { }

  ngOnInit() {
    this.getStations();    
  }

  getStations() {
    this.stationService.getStations().subscribe(stations => this.stations = stations)
  }

  setKey(key: string) {        
    this.userInput += key
    this.filteredStations = [];
    this.nextKeys = []

    this.stations.forEach(station => {
      if (station.name.startsWith(this.userInput)) {
        this.filteredStations.push(station)
        this.nextKeys.push(station.name.substring(this.userInput.length, (this.userInput.length + 1)).toLowerCase())
      }            
    });

    if (this.filteredStations.length === 1) {
      this.keyboard.forEach(key => {
        key.enabled = false
      });

      this.userInput = this.filteredStations[0].name
      return;      
    }    

    this.keyboard.forEach(key => {
      key.enabled = false
      
      if (this.nextKeys.indexOf(key.key.toLowerCase()) > -1)
      key.enabled = true
    });   
  }

  clear() {
    this.keyboard.forEach(key => {
      (key.key !== "") ? key.enabled = true : key.enabled = false
    });

    this.userInput = ""
    this.filteredStations = [];
  }
}
