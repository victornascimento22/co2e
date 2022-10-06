using System;

namespace co2e.DataObjectTransfer
{
    internal class SourceMemberAttribute : Attribute
    {
        private string v;

        public SourceMemberAttribute(string v)
        {
            this.v = v;
        }
    }
}