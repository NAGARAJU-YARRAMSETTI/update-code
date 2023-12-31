﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;

namespace dotnetapp
{
    public class BusinessLayer
    {
        private DataAccessLayer data_Access_layer = new DataAccessLayer();
        //Auth Controller

        public bool isUserPresent(LoginModel data)
        {
            return data_Access_layer.isUserPresent(data);
        }
        public bool isAdminPresent(LoginModel data)
        {
            return data_Access_layer.isAdminPresent(data);
        }
        public string saveUser(UserModel user)
        {
            return data_Access_layer.saveUser(user);
        }
        public string saveAdmin(UserModel user)
        {
            return data_Access_layer.saveAdmin(user);
        }


        //Admin Controller

        public List<LoanModel> getAllLoans()
        {
            return data_Access_layer.getAllLoans();
        }

        public string approveLoan(int loanId, string status)
        {
            return data_Access_layer.approveLoan(loanId, status);
        }

        public string addDocuments(IFormCollection data, IFormFile file)
        {

            long length = file.Length;
            using var fileStream = file.OpenReadStream();
            byte[] bytes =  new byte[length];
            fileStream.Read(bytes, 0, (int)file.Length);
            DocumentModel documentModel = new DocumentModel();
            documentModel.documenttype = data["documenttype"];
            documentModel.documentupload = bytes;
            return data_Access_layer.addDocuments(documentModel);
        }

        public string editDocuments(int documentId, DocumentModel data)
        {
            return data_Access_layer.editDocuments(documentId, data);
        }

        public DocumentModel getDocuments(int documentId)
        {
            return data_Access_layer.getDocuments(documentId);
        }
        public string deleteDocuments(int documentId)
        {
            return data_Access_layer.deleteDocuments(documentId);
        }




        //UserController

        public string addUser(ProfileModel pm)
        {
            return data_Access_layer.addUser(pm);
        }

        public ProfileModel getUser(string userId)
        {
            return data_Access_layer.getUser(userId);
        }


        public string editUser(string userId, ProfileModel data)
        {
            return data_Access_layer.editUser(userId, data);
        }

        public string deleteUser(string userId)
        {
            return data_Access_layer.deleteUser(userId);
        }




        //LoanController

        public LoanModel getLoan(int loanId)
        {
            return data_Access_layer.getLoan(loanId);
        }



        public string addLoan(LoanModel Data)
        {
            return data_Access_layer.addLoan(Data);
        }

        public string editLoan(int LoanId, LoanModel Data)
        {
            return data_Access_layer.editLoan(LoanId, Data);
        }


        public string deleteLoan(int LoanId)
        {
            return data_Access_layer.deleteLoan(LoanId);
        }

        //Review Controller
        public string AddReview(ReviewModel review)
        {
            return data_Access_layer.AddReview(review);
        }
        public List<ReviewModel> GetReviews()
        {
            return data_Access_layer.GetReviews();
        }
    }
}


