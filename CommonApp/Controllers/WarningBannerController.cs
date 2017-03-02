using CommonApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CommonApp.Controllers
{
    public class WarningBannerController : ApiController
    {
        IList<WarningBanner> warningBanners = new List<WarningBanner>
        {
            new WarningBanner { Id = 1, Content = "<p style='text-align: CENTER'><span style='font-size: 10pt'>**WARNING**WARNING**WARNING**</span></p>" +
"<p><span style = 'font-size: 10pt' > This is a (</span><span style = 'font-size: 10pt' ><span style = 'text-decoration: underline' > XYZ </span>) computer system. (</span><span style = 'font-size: 10pt' ><span style = 'text-decoration: underline' > XYZ </span>) computer" +
                                  " systems are provided for the processing of Official abc" +
                                  " gov information only.All data contained on" +
                                  " (</span><span style = 'font-size: 10pt' ><span style = 'text-decoration: underline' > XYZ </span>) computer systems is owned by the(</span><span style = 'font-size: 10pt' ><span style = 'text-decoration: underline' > XYZ </span>)" +
                                  " </span><span style = 'font-size: 10pt' ><em> may be monitored, intercepted, recorded, read, copied," +
                                  " or captured in any manner and disclosed in any manner," +
                                  " </ em > by authorized personnel.THERE IS NO RIGHT OF" +
                                   " PRIVACY IN THIS SYSTEM.System personnel may" +
                                  " give to law enforcement officials any potential evidence" +
                                  " of crime found on(</span><span style = 'font-size: 10pt' ><span style = 'text-decoration: underline'> XYZ </span>) computer systems. </span><span style = 'font-size: 10pt' ><em><span style = 'text-decoration: underline'> USE OF" +
                                 "  THIS SYSTEM BY ANY USER, AUTHORIZED OR" +
                                  " UNAUTHORIZED, CONSTITUTES CONSENT TO THIS" +
                                  " MONITORING, INTERCEPTION, RECORDING," +
                                  " READING, COPYING, OR CAPTURING and" +
                                   " DISCLOSURE.</span></ em ></span><span style = 'font-size: 10pt' ><span style = 'text-decoration: underline' ></span></span></p>" +
                                   "<p style = 'text-align: CENTER' ><span style = 'font-size: 10pt' > **WARNING * *WARNING * *WARNING * *</span></p> ",
             LastUpdatedDate = DateTime.Now},
            new WarningBanner { Id = 2, Content = "By clicking on the OK button below and logging into the (your company name here) domain," + 
                "you agree to abide by the terms of the (your company name here) IT and Electronic Communications Policy. " + 
                "A copy of this policy can be viewed on the intranet. " +
                "The type of material you access on the Internet is strictly monitored and filtered. " +
                "Users are responsible for ensuring that they act in accordance with this policy and other " + 
                "policies and legislation applicable to the (your company name here) network.", LastUpdatedDate= DateTime.Now.AddDays(-30)}
        };

        [HttpGet()]
        public IEnumerable<WarningBanner> GetAllWarningBanner()
        {
            return warningBanners;
        }

        public IHttpActionResult GetWarningBanner(int id)
        {
            var banner = warningBanners.FirstOrDefault((p) => p.Id == id);
            if (banner == null)
            {
                return NotFound();
            }
            return Ok(banner);
        }

    }
}
