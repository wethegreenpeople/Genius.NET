﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genius.NET.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ContentRetriever.AuthorizationToken = "ldslsxMqENSqAk5u1xExamNhiKVRv_IaVz_xQU2q--QYdhi-jlxGZ9LAM0Pvyffe";
            //ContentRetriever.GetAnnotationbyId("10225840");
            //ContentRetriever.GetReferentsbySongId("12");
            var song = ContentRetriever.GetSongbyId("378195");
            try
            {
                Console.WriteLine(song.Result);
            }
            catch (AggregateException e)
            {
                Debug.WriteLine(e);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
