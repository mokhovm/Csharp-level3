using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestMailSender.Model
{
    public class CustomObject
    {
        public Guid Id { get; set; }


        public CustomObject()
        {
            Id = Guid.NewGuid();
        }
    }
}
