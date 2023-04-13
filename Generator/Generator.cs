/*
 * Generator.cs
 *
 *   Created: 2022-11-24-03:58:59
 *   Modified: 2022-11-24-03:58:59
 *
 *   Author: David G. Mooore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Mooore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
using System.Linq;
using System.Net.Mime;

public class Generator
{
    public static void Main(string[] args)
    {
        var mimeTypes = MimeTypes.MimeTypeMap.Mappings.Select(mimeType => new ContentType(mimeType.Value)).ToList();
    }
}
