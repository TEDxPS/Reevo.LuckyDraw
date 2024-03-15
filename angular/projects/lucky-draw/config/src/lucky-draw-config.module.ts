import { ModuleWithProviders, NgModule } from '@angular/core';
import { LUCKY_DRAW_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class LuckyDrawConfigModule {
  static forRoot(): ModuleWithProviders<LuckyDrawConfigModule> {
    return {
      ngModule: LuckyDrawConfigModule,
      providers: [LUCKY_DRAW_ROUTE_PROVIDERS],
    };
  }
}
