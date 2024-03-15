import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class LuckyDrawService {
  apiName = 'LuckyDraw';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/LuckyDraw/sample' },
      { apiName: this.apiName }
    );
  }
}
