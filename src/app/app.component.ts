import { Component } from '@angular/core';
import { ConfigService } from './services/config.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SockPairs';

  constructor(private service:ConfigService) {}

  result:number;
  pairsString:string;

  callPairs(){
    let pairs:string;
    pairs = this.pairsString;

    this.service.postPairs({pairs})
      .subscribe(arg => this.result = arg.result);

  }
}

