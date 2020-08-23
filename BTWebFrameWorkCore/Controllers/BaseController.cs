﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTWebAppFrameWorkCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTWebAppFrameWorkCore.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseViewModel _BaseViewModel;

        public BaseController()
        {
            _BaseViewModel = new BaseViewModel
            {
                PageTitle = "Home",
                BUserName = "Unknown",
                BUserImgPath = "~/assets/img/AppUser/BlankUser.jpg",
                BreadCrumbItems = new List<AppBreadCrumb>()
            };
            GetUserMessage(); // get the unread message and notification from db
        }

        public void CreateBreadCrumb(dynamic BreadCrumbItems)
        {
            _BaseViewModel.BreadCrumbItems = new List<AppBreadCrumb>();
            foreach (var item in BreadCrumbItems)
            {
                _BaseViewModel.BreadCrumbItems.Add(new AppBreadCrumb { Name = item.Name, ActionUrl = item.ActionUrl });
            }
        }

        public BaseViewModel GetViewModel<T>()
        {            
            BaseViewModel TempBaseViewModel = (BaseViewModel) Activator.CreateInstance(typeof(T));
            TempBaseViewModel.CopyToBase(_BaseViewModel);
            return TempBaseViewModel;
        }

        private void GetUserMessage()
        {
            // get top 3 unread meggage from db
            _BaseViewModel.UserMsgItems = new List<UserMessageInfo>();
            _BaseViewModel.UserMsgItems.Add(new UserMessageInfo
            {
                ID = "A001",
                Name = "Brad Diesel",
                Message = "Call me whenever you can...",
                TimeRef = "4 Hours Ago",
                UserAvatar = "/img/user1-128x128.jpg"
            });
            _BaseViewModel.UserMsgItems.Add(new UserMessageInfo
            {
                ID = "A002",
                Name = "John Pierce",
                Message = "I got your message bro",
                TimeRef = "6 Hours Ago",
                UserAvatar = "/img/user3-128x128.jpg"
            });
            _BaseViewModel.UserMsgItems.Add(new UserMessageInfo
            {
                ID = "A003",
                Name = "Nora Silvester",
                Message = "The subject goes here",
                TimeRef = "9 Hours Ago",
                UserAvatar = "/img/user8-128x128.jpg"
            });

            // get top unread notification from db
            _BaseViewModel.UserNotification = new UserNotificationInfo();
            _BaseViewModel.UserNotification.TotalNotification = "15";
            _BaseViewModel.UserNotification.MsgItems = new List<UserNotificationItem>();
            _BaseViewModel.UserNotification.MsgItems.Add(new UserNotificationItem
            {
                NotifyType = "M",
                Message = "4 new messages",
                TimeRef = "3 mins"
            });
            _BaseViewModel.UserNotification.MsgItems.Add(new UserNotificationItem
            {
                NotifyType = "R",
                Message = "8 friend requests",
                TimeRef = "12 hours"
            });
            _BaseViewModel.UserNotification.MsgItems.Add(new UserNotificationItem
            {
                NotifyType = "RPT",
                Message = "3 new reports",
                TimeRef = "2 days"
            });
        }

    }
}