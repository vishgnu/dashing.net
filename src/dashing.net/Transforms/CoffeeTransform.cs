﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace dashing.net.Transforms
{
    public class CoffeeTransform : IBundleTransform
    {
        public void Process(BundleContext context, BundleResponse response)
        {
            var coffee = new CoffeeSharp.CoffeeScriptEngine();

            response.ContentType = "text/javascript";
            response.Content = string.Empty;

            foreach (var fileInfo in response.Files)
            {
                if (fileInfo.Extension.Equals(".coffee", StringComparison.Ordinal))
                {
                    var result = coffee.Compile(File.ReadAllText(fileInfo.FullName));

                    response.Content += result;
                }
                else if (fileInfo.Extension.Equals(".js", StringComparison.Ordinal))
                {
                    response.Content += File.ReadAllText(fileInfo.FullName);
                }
            }
        }
    }
}