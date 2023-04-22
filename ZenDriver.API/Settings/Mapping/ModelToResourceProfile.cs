using AutoMapper;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Resources;

namespace ZenDriver.API.Settings.Mapping;
public class ModelToResourceProfile :Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<SocialNetwork, SocialNetworkResource>();
        CreateMap<Address, AddressResource>();
        CreateMap<Company, CompanyResource>();
        CreateMap<Post, PostResource>();
        CreateMap<Recruiter, RecruiterResource>();
        CreateMap<Message, MessageResource>();
        CreateMap<Notification, NotificationResource>();
        CreateMap<Driver, DriverResource>();
        CreateMap<Driverprofile, DriverprofileResource>();
        CreateMap<License, LicenseResource>();
        CreateMap<Education, EducationResource>();
        CreateMap<School, SchoolResource>();
    }
}