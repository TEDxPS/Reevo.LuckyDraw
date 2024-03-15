import { Component, OnInit } from '@angular/core';
import { LuckyDrawService } from '../services/lucky-draw.service';

@Component({
  selector: 'lib-lucky-draw',
  template: ` <p>lucky-draw works!</p> `,
  styles: [],
})
export class LuckyDrawComponent implements OnInit {
  constructor(private service: LuckyDrawService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
