import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { StationModel } from '../models/station.model';
import { Observable } from 'rxjs';
import { API } from '../app.settings';
import { tap } from "rxjs/operators";

@Injectable()
export class StationService {

    constructor(private http: HttpClient) {}

    getStations(): Observable<StationModel[]> {
        return this.http.get<StationModel[]>(`${API}/station`, {})
    }

}