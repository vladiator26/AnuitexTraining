import {Component, OnInit} from '@angular/core';
import {Store} from "@ngrx/store";
import {AccountState} from "./modules/account/interfaces/account.state";
import {getAccessTokenSelector, getIsLoggedInSelector} from "./modules/account/store/account.selectors";
import {SignInSuccessAction, SignOutAction, SignOutSuccess} from "./modules/account/store/account.actions";
import {Router} from "@angular/router";
import {Actions, ofType} from "@ngrx/effects";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  private accessToken: string;

  constructor(private store: Store<AccountState>,
              private router: Router,
              private actions$: Actions) {
  }

  title = 'app';
  isLoggedIn$ = this.store.select(getIsLoggedInSelector);

  ngOnInit() {
    let accessToken = localStorage.getItem("accessToken");
    let refreshToken = localStorage.getItem("refreshToken")
    if ((accessToken != 'null' && accessToken != null) && (refreshToken != 'null' && refreshToken != null)) {
      this.store.dispatch(new SignInSuccessAction({
        accessToken: accessToken,
        refreshToken: refreshToken,
        rememberMe: true
      }))
    }
    this.actions$.pipe(ofType(SignOutSuccess)).subscribe(() => {
      this.router.navigate(["account", "signIn"]).then();
    })
  }

  signOut() {
    this.store.dispatch(new SignOutAction());
  }

  profile() {
    this.store.select(getAccessTokenSelector).subscribe(item => this.accessToken = item)
    let id = JSON.parse(atob(this.accessToken.split('.')[1])).Id;
    this.router.navigate(["user", "profile"], {
      queryParams: {
        id: id
      }
    }).then()
  }
}
