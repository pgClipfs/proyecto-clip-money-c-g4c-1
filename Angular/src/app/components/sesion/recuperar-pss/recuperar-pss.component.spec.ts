import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RecuperarPssComponent } from './recuperar-pss.component';

describe('RecuperarPssComponent', () => {
  let component: RecuperarPssComponent;
  let fixture: ComponentFixture<RecuperarPssComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RecuperarPssComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RecuperarPssComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
