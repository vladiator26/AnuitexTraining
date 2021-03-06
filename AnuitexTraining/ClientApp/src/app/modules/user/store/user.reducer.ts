﻿import {UserState} from "../models/user.state";
import {GetUserSuccess, UpdateUserSuccess, UserActions, UserFail} from "./user.actions";
import {min} from "rxjs/operators";

export const userInitialState: UserState = {
  id: 0,
  firstName: '',
  lastName: '',
  nickName: '',
  email: '',
  password: '',
  phoneNumber: '',
  isBlocked: false,
  creationDate: null
}

export const getUser = (state: UserState) => state;

export function userReducer(state = userInitialState, action: UserActions) {
  switch (action.type) {
    case GetUserSuccess:
      return action.payload;
    case UpdateUserSuccess:
      return action.payload;
    default:
      return state;
  }
}
