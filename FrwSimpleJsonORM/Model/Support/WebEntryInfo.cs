﻿/**********************************************************************************
 *   FrwSimpleWinCRUD   https://github.com/frwsoftware/FrwSimpleWinCRUD
 *   The Open-Source Library for most quick  WinForm CRUD application creation
 *   MIT License Copyright (c) 2016 FrwSoftware
 *
 *   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *   AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *   LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *   OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *   SOFTWARE.
 **********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FrwSoftware
{
    public enum ViewType
    {
        NONE,
        WORD,
        IE,
        Simple,
        Awesomium,  
        CefBrowser
    }

    public class WebEntryInfo
    {
        public string Url { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }


        static public WebEntryInfo GetWebEntryInfoFromObject(object o)
        {
            if (o == null) return null;
            PropertyInfo p = o.GetType().GetProperties().Where(
                prop => prop.PropertyType == typeof(WebEntryInfo)).FirstOrDefault();
            if (p == null) return null;
            return p.GetValue(o) as WebEntryInfo;
        }
    }
}