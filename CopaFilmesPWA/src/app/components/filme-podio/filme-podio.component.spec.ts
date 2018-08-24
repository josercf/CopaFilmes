import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FilmePodioComponent } from './filme-podio.component';

describe('FilmePodioComponent', () => {
  let component: FilmePodioComponent;
  let fixture: ComponentFixture<FilmePodioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FilmePodioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FilmePodioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
