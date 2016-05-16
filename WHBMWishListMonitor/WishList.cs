using System;
using System.Collections.Generic;
using System.Net;

namespace WHBMWishListMonitor
{
  public class WishList
  {
    private Dictionary<string, float> _items = new Dictionary<string, float>();

    //class constructor
    public WishList()
    {
      Credentials credentials = new Credentials();
      FetchList(credentials);
    }

    private void FetchList(Credentials credentials)
    {
      string page = new WebClient();
      page.
      Console.WriteLine(new WebClient().DownloadString(credentials.WebPage));
    }

  }
}