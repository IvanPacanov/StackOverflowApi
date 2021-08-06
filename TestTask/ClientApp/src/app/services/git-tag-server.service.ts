import { Injectable, Inject } from '@angular/core';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { MostPopularTag } from '../entities/mostPopularTag';
import { HttpClient} from '@angular/common/http';
import { ConfigureToSearch } from '../entities/configureToSearch';

@Injectable({
  providedIn: 'root'
})
export class GitTagServerService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }



  getTags(): Observable<MostPopularTag[]>{
    return this.http.get<MostPopularTag[]>(this.baseUrl + 'Git/GetTagByDefaulValue').pipe(tap(console.log));;
  }

  getTagsOfSize(val: ConfigureToSearch): Observable<MostPopularTag[]>{
    return this.http.post<MostPopularTag[]>(this.baseUrl + 'Git/GetWithFilter', val).pipe(tap(console.log));;
  }
}
