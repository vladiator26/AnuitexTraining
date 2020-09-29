﻿import {Action} from "@ngrx/store";
import {UserState} from "../../user/models/user.state";
import {FailModel} from "../../shared/models/fail.model";
import {AuthorModel} from "../models/author.model";
import {GetPageSuccessModel} from "../models/get-page-success.model";
import {GetPageModel} from "../models/get-page.model";

export const GetUsers = '[Administrator] Get Users';
export const GetUsersSuccess = '[Administrator] Get Users Success';
export const AdministratorFail = '[Administrator] Fail';
export const DeleteUser = '[Administrator] Delete User';
export const DeleteUserSuccess = '[Administrator] Delete User Success';
export const GetAuthors = '[Administrator] Get Authors';
export const GetAuthorsSuccess = '[Administrator] Get Authors Success';
export const AddAuthor = '[Administrator] Add Author';
export const AddAuthorSuccess = '[Administrator] Add Author Success';
export const EditAuthor = '[Administrator] Edit Author';
export const EditAuthorSuccess = '[Administrator] Edit Author Success';
export const DeleteAuthor = '[Administrator] Delete Author';
export const DeleteAuthorSuccess = '[Administrator] Delete Author Success'

export class DeleteUserSuccessAction implements Action {
  readonly type = DeleteUserSuccess
}

export class GetUsersAction implements Action {
  readonly type = GetUsers;
  constructor(public payload: GetPageModel<UserState>) {
  }
}

export class GetUsersSuccessAction implements Action {
  readonly type = GetUsersSuccess;
  constructor(public payload: GetPageSuccessModel<UserState>) {
  }
}

export class AdministratorFailAction implements Action {
  readonly type = AdministratorFail;
  constructor(public payload: FailModel) {
  }
}

export class DeleteUserAction implements Action {
  readonly type = DeleteUser;
  constructor(public payload: number) {
  }
}

export class GetAuthorsAction implements Action {
  readonly type = GetAuthors;
  constructor(public payload: GetPageModel<AuthorModel>) {
  }
}

export class GetAuthorsSuccessAction implements Action {
  readonly type = GetAuthorsSuccess;
  constructor(public payload: GetPageSuccessModel<AuthorModel>) {
  }
}

export class AddAuthorAction implements Action {
  readonly type = AddAuthor;
  constructor(public payload: AuthorModel) {
  }
}

export class AddAuthorSuccessAction implements Action {
  readonly type = AddAuthorSuccess;
}

export class EditAuthorAction implements Action {
  readonly type = EditAuthor;
  constructor(public payload: AuthorModel) {
  }
}

export class EditAuthorSuccessAction implements Action {
  readonly type = EditAuthorSuccess;
}

export class DeleteAuthorAction implements Action {
  readonly type = DeleteAuthor;
  constructor(public payload: number) {
  }
}

export class DeleteAuthorSuccessAction implements Action {
  readonly type = DeleteAuthorSuccess;
}

export type AdministratorActions = GetUsersAction  | GetAuthorsSuccessAction | AdministratorFailAction | DeleteUserAction | DeleteUserSuccessAction
  | GetAuthorsAction | GetUsersSuccessAction | AddAuthorAction | AddAuthorSuccessAction | EditAuthorAction | EditAuthorSuccessAction |
  DeleteAuthorAction | DeleteAuthorSuccessAction;