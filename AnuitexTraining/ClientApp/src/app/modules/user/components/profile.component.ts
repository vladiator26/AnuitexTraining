﻿import {Component, OnInit} from "@angular/core";
import {Store} from "@ngrx/store";
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {getAccessTokenSelector} from "../../account/store/account.selectors";
import {GetUserAction, UpdateUserAction} from "../store/user.actions";
import {getUserSelector} from "../store/user.selectors";
import {UserState} from "../models/user.state";
import {AccountState} from "../../account/interfaces/account.state";
import {
  checkContainsLength,
  checkContainsNumeric,
  checkContainsSpecialCharacter,
  checkContainsUpper
} from "../../shared/validators";
import {ActivatedRoute} from "@angular/router";

@Component({
  selector: 'user-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  constructor(private userStore: Store<UserState>,
              private accountStore: Store<AccountState>,
              private route: ActivatedRoute) {
  }

  user: UserState;
  id: string;

  firstNameControl = new FormControl({value: '', disabled: true}, {
    validators: [
      Validators.required
    ]
  });
  lastNameControl = new FormControl({value: '', disabled: true}, {
    validators: [
      Validators.required
    ]
  });
  nickNameControl = new FormControl({value: '', disabled: true}, {
    validators: [
      Validators.required
    ]
  });
  emailControl = new FormControl({value: '', disabled: true}, {
    validators: [
      Validators.required,
      Validators.email
    ]
  });
  passwordControl = new FormControl('', {
    validators: [
      checkContainsUpper,
      checkContainsLength,
      checkContainsSpecialCharacter,
      checkContainsNumeric
    ]
  });
  confirmPasswordControl = new FormControl('');

  form = new FormGroup({
    firstName: this.firstNameControl,
    lastName: this.lastNameControl,
    nickName: this.nickNameControl,
    email: this.emailControl,
    password: this.passwordControl,
    confirmPassword: this.confirmPasswordControl
  });

  accessToken: string;
  isEditing: boolean;

  ngOnInit() {
    this.accountStore.select(getAccessTokenSelector).subscribe(item => this.accessToken = item);
    if (this.accessToken != '') {
      this.route.queryParams.subscribe(params => {
        this.id = params.id;
      })
      this.userStore.dispatch(new GetUserAction(this.id));
      this.userStore.select(getUserSelector).subscribe((item: UserState) => {
        this.user = item;
        this.firstNameControl.setValue(item.firstName);
        this.lastNameControl.setValue(item.lastName);
        this.emailControl.setValue(item.email);
        this.nickNameControl.setValue(item.nickName);
      });
    }
  }

  applyChanges() {
    if (this.form.valid) {
      let state: UserState = {
        id: this.user.id,
        firstName: this.firstNameControl.value,
        lastName: this.lastNameControl.value,
        nickName: this.nickNameControl.value,
        email: this.emailControl.value,
        password: this.passwordControl.value,
        phoneNumber: '',
        isBlocked: this.user.isBlocked,
        creationDate: this.user.creationDate
      }
      this.userStore.dispatch(new UpdateUserAction(state));
      this.userStore.select(getUserSelector).subscribe(item => {
          this.user = item;
          this.firstNameControl.setValue(item.firstName);
          this.lastNameControl.setValue(item.lastName);
          this.emailControl.setValue(item.email);
          this.nickNameControl.setValue(item.nickName);
        }
      )
      this.cancel()
    }
  }

  edit() {
    this.isEditing = true;
    this.firstNameControl.enable();
    this.lastNameControl.enable();
    this.nickNameControl.enable();
    this.emailControl.enable();
  }

  cancel() {
    this.isEditing = false;
    this.firstNameControl.disable();
    this.lastNameControl.disable();
    this.nickNameControl.disable();
    this.emailControl.disable();
  }
}
