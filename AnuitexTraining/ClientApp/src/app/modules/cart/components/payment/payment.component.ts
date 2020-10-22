import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialog, MatDialogRef} from "@angular/material/dialog";
import {AuthorModel} from "../../../administrator/models/author.model";
import {OrderModel} from "../../models/order.model";
import {StripeSource, StripeToken} from "stripe-angular";
import {Store} from "@ngrx/store";
import {BuyCartAction, BuyCartSuccess, BuyCartSuccessAction} from "../../store/cart.actions";
import {getStateSelector} from "../../store/cart.selectors";
import {AccountState} from "../../../account/interfaces/account.state";
import {getAccessTokenSelector} from "../../../account/store/account.selectors";
import {Actions, ofType} from "@ngrx/effects";
import {SuccessComponent} from "../success/success.component";

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent implements OnInit {
  order: OrderModel
  userId: number

  constructor(@Inject(MAT_DIALOG_DATA) public data: number,
              private store: Store<OrderModel>,
              private accountStore: Store<AccountState>,
              private actions$: Actions,
              private dialogRef: MatDialogRef<PaymentComponent>,
              private dialog: MatDialog) {
  }

  ngOnInit() {
    this.store.select(getStateSelector).subscribe(item => {
      this.order = item
    })
    this.accountStore.select(getAccessTokenSelector).subscribe(item => {
      this.userId = Number(JSON.parse(atob(item.split(".")[1])).Id)
    })
    this.actions$.pipe(ofType(BuyCartSuccess)).subscribe((action: BuyCartSuccessAction) => {
      localStorage.removeItem("cart");
      this.dialog.open(SuccessComponent, {data: action.payload })
      this.dialogRef.close()
    });
  }

  setStripeToken( token:StripeToken ){
    console.log('Stripe token', token)
    this.order.transactionToken = token.id;
    this.order.date = new Date();
    this.order.userId = this.userId;
    this.store.dispatch(new BuyCartAction(this.order))
  }

}
