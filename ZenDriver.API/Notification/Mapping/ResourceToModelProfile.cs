﻿using AutoMapper;
using ZenDriver.API.Message.Resources;
using ZenDriver.API.Notification.Resources;
using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Resources;

namespace ZenDriver.API.Notification.Mapping;
public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveNotificationResource, Notification.Domain.Models.Notification> ();
    }
}
