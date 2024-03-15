import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { LuckyDrawComponent } from './components/lucky-draw.component';
import { LuckyDrawRoutingModule } from './lucky-draw-routing.module';

@NgModule({
  declarations: [LuckyDrawComponent],
  imports: [CoreModule, ThemeSharedModule, LuckyDrawRoutingModule],
  exports: [LuckyDrawComponent],
})
export class LuckyDrawModule {
  static forChild(): ModuleWithProviders<LuckyDrawModule> {
    return {
      ngModule: LuckyDrawModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<LuckyDrawModule> {
    return new LazyModuleFactory(LuckyDrawModule.forChild());
  }
}
