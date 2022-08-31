using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoNonoDesafio {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {
        }
    }
}
