using AutoMapper;
using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Resources;

namespace ZenDriver.API.Settings.Mapping;
public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveSocialNetworkResource, SocialNetwork> ();
        CreateMap<SaveAddressResource, Address> ();
        CreateMap<SavePostResource, Post> ();
        CreateMap<SaveCompanyResource, Company> (); 
        CreateMap<SaveRecruiterResource, Recruiter> ();
        CreateMap<SaveMessageResource, Message> ();
        CreateMap<SaveNotificationResource, Notification> ();
        CreateMap<SaveDriverResource, Driver> ();
        CreateMap<SaveDriverprofileResource, Driverprofile> ();
        CreateMap<SaveEducationResource, Education> ();
        CreateMap<SaveLicenseResource, License> ();
        CreateMap<SaveSchoolResource, School> ();
    }
}
