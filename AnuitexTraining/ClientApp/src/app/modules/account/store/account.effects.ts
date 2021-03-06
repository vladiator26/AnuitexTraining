import {Injectable} from "@angular/core";
import {Actions, Effect, ofType} from "@ngrx/effects";
import {AccountService} from "../services/account.service";
import {
  AccountFail,
  AccountFailAction,
  AccountShowErrorsAction,
  ConfirmEmail,
  ConfirmEmailAction,
  ConfirmEmailRedirectAction,
  ConfirmEmailSuccessAction,
  ForgotPassword,
  ForgotPasswordAction,
  ForgotPasswordSuccessAction,
  SignIn,
  SignInAction,
  SignInCookieUpdateAction,
  SignInSuccess,
  SignInSuccessAction,
  SignOut,
  SignOutAction,
  SignOutSuccessAction,
  SignUp,
  SignUpAction,
  SignUpSuccess,
  SignUpSuccessAction
} from "./account.actions";
import {catchError, map, mergeMap} from 'rxjs/operators';
import {of} from "rxjs";
import {CookieService} from "ngx-cookie-service";
import {MatSnackBar} from "@angular/material/snack-bar";
import {SignInSuccessModel} from "../models/sign-in/sign-in-success.model";
import {Router} from "@angular/router";
import {ConfirmEmailSuccessModel} from "../models/confirm-email/confirm-email-success.model";

@Injectable()
export class AccountEffects {
  constructor(private actions$: Actions,
              private accountService: AccountService,
              private snackBar: MatSnackBar,
              private router: Router) {
  }

  @Effect()
  signIn$ = this.actions$.pipe(ofType(SignIn),
    mergeMap((action: SignInAction) => {
      return this.accountService.signIn(action.payload)
        .pipe(
          map((data: SignInSuccessModel) => {
            data.rememberMe = action.payload.rememberMe;
            return new SignInSuccessAction(data);
          }),
          catchError(error => {
            return of(new AccountFailAction(error.error));
          })
        );
    })
  );

  @Effect()
  signUp$ = this.actions$.pipe(ofType(SignUp),
    mergeMap((action: SignUpAction) => {
      return this.accountService.signUp(action.payload)
        .pipe(
          map(() => {
            return new SignUpSuccessAction();
          }),
          catchError(error => {
            return of(new AccountFailAction(error.error));
          })
        );
    }));

  @Effect()
  cookieUpdate$ = this.actions$.pipe(ofType(SignInSuccess),
    mergeMap((action: SignInSuccessAction) => {
      if (action.payload.rememberMe) {
        localStorage.setItem('accessToken', action.payload.accessToken);
        localStorage.setItem('refreshToken', action.payload.refreshToken);
      }
      return of(new SignInCookieUpdateAction());
    }));

  @Effect()
  showError$ = this.actions$.pipe(ofType(AccountFail),
    mergeMap((action: AccountFailAction) => {
      this.snackBar.open(action.payload.Errors.join(" "), "Ok", {
        horizontalPosition: "end",
        verticalPosition: "top",
        panelClass: 'snackbar'
      })
      return of(new AccountShowErrorsAction());
    }));

  @Effect()
  redirectToEmailConfirm$ = this.actions$.pipe(ofType(SignUpSuccess),
    mergeMap(() => {
      this.router.navigate(['/', 'account', 'confirmEmail']).then();
      return of(new ConfirmEmailRedirectAction());
    }));

  @Effect()
  confirmEmail$ = this.actions$.pipe(ofType(ConfirmEmail),
    mergeMap((action: ConfirmEmailAction) => {
      return this.accountService.confirmEmail(action.payload)
        .pipe(
          map((data: ConfirmEmailSuccessModel) => {
            return new ConfirmEmailSuccessAction(data);
          }),
          catchError(error => {
            return of(new AccountFailAction(error.error));
          })
        )
    }));

  @Effect()
  resetPassword$ = this.actions$.pipe(ofType(ForgotPassword),
    mergeMap((action: ForgotPasswordAction) => {
      return this.accountService.forgotPassword(action.payload)
        .pipe(
          map(() => {
            return new ForgotPasswordSuccessAction();
          }),
          catchError(error => {
            return of(new AccountFailAction(error.error));
          })
        )
    }));

  @Effect()
  signOut$ = this.actions$.pipe(ofType(SignOut),
    mergeMap((action: SignOutAction) => {
      return this.accountService.signOut()
        .pipe(
          map(() => {
            localStorage.removeItem('accessToken');
            localStorage.removeItem('refreshToken');
            return new SignOutSuccessAction();
          }),
          catchError(error => {
            return of(new AccountFailAction(error.error))
          })
        );
    }));
}
