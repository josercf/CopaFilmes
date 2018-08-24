import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SelecaoPageComponent } from './selecao-page.component';

describe('SelecaoPageComponent', () => {
  let component: SelecaoPageComponent;
  let fixture: ComponentFixture<SelecaoPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SelecaoPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SelecaoPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
