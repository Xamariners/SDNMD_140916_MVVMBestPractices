using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Shared.Enums;
using PropertyChanged;

namespace MVVMBestPractices.Shared.Models
{
    [DataContract]
    [ImplementPropertyChanged]
    public class ToDoItem : ObjectBase
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Details { get; set; }

        [DataMember]
        public ToDoStatus ToDoStatus { get; set; }

        [DataMember]
        public DateTime? CompletionDate { get; set; }
    }
}
