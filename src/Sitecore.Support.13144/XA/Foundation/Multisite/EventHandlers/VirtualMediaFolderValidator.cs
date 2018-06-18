using Microsoft.Extensions.DependencyInjection;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.DependencyInjection;
using Sitecore.Events;
using Sitecore.XA.Foundation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.XA.Foundation.Multisite;

namespace Sitecore.Support.XA.Foundation.Multisite.EventHandlers
{
  public class VirtualMediaFolderValidator: Sitecore.XA.Foundation.Multisite.EventHandlers.VirtualMediaFolderValidator
  {
    new protected void OnItemMoving(object obj, EventArgs args)
    {
      
      Database contentDatabase = ServiceProviderServiceExtensions.GetService<IContext>(ServiceLocator.ServiceProvider).ContentDatabase;
      if(contentDatabase!=null)
      {
        base.OnItemMoving(obj, args);
      }
    }
  }
}