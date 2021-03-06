﻿using MVP.Client.Views;
using MVP.Core.Dtos;
using MVP.Core.Interfaces;
using MVP.Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Client.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IUserRepository _userRepository;

        public LoginPresenter(ILoginView view, IUserRepository userRepository)
        {
            _view = view;
            _view.LoginPresenter = this;
            _userRepository = userRepository;
        }

        public ILoginView GetLoginView()
        {
            return _view;
        }

        public void Login()
        {
            var username = _view.Username;
            var password = _view.Password;

            var user = _userRepository.GetUser(username);

            if (user == null)
            {
                _view.Message = "Login failed.";
                _view.IsLogin = false;
                return;
            }

            if (user.Password != password)
            {
                _view.Message = "Password incorrect.";
                _view.IsLogin = false;
                return;
            }

            _view.IsLogin = true;
            _view.Message = $"Login success. Welcome {user.Firstname} {user.Lastname}";



        }

    }
}
