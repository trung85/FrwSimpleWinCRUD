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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace FrwSoftware.Model.Chinook
{
    [JEntity]
    public class Invoice
    {
        [JPrimaryKey, JReadOnly, JAutoIncrement]
        public int InvoiceId { get; set; }


        [JNameProperty]
        public DateTime InvoiceDate { get; set; }

        public string BillingAddress { get; set; }

        public string BillingCity { get; set; }

        public string BillingState { get; set; }

        public string BillingCountry { get; set; }

        public string BillingPostalCode { get; set; }

        public decimal Total { get; set; }

        [JManyToOne]
        public Customer Customer { get; set; }
    }
}
