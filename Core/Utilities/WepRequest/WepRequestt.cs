using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace Core.Utilities.WepRequest
{
    public class WepRequestt:IWepRequest
    {
        public void CallUrl(string url)
        {

            System.Diagnostics.Stopwatch timer = new Stopwatch();

            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(url);
            httpReq.Timeout = 111110;
            timer.Start();
            httpReq.AllowAutoRedirect = true;

            try
            {
                using (HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse())
                {
                    
                    using (Stream answer = httpRes.GetResponseStream())
                    {
                        timer.Stop();
                        TimeSpan timeTaken = timer.Elapsed;
                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        timeTaken.Hours, timeTaken.Minutes, timeTaken.Seconds,
                        timeTaken.Milliseconds / 10);
                        Console.WriteLine("Response Time " + elapsedTime);

                        if (httpRes.StatusCode == HttpStatusCode.OK)
                        {
                            Console.WriteLine("Status Code 200 : ");

                        }
                        else if (httpRes.StatusCode == HttpStatusCode.Moved)
                        {
                            Console.WriteLine("Status Code 301 Url : " + url);
                        }

                        else if (httpRes.StatusCode == HttpStatusCode.BadRequest)
                        {
                            Console.WriteLine("Status Code 400 Url : " + url);
                        }
                        else if (httpRes.StatusCode == HttpStatusCode.Found)
                        {
                            Console.WriteLine("Status Code 302 Url : " + url);

                        }
                        httpRes.Close();
                    }
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.Timeout)
                {
                    Console.WriteLine("Timeout Exception");
                }
                else throw;
            }

            
            
           
           
            }
            




           
        }
    }

