import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QrtarjetaComponent } from './qrtarjeta.component';

describe('QrtarjetaComponent', () => {
  let component: QrtarjetaComponent;
  let fixture: ComponentFixture<QrtarjetaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QrtarjetaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(QrtarjetaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
