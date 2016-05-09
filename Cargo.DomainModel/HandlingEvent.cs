using System;

namespace Cargo.DomainModel
{
    public class HandlingEvent
    {
        private DateTime _completionTime;

        public DateTime CompletionTime
        {
            get { return _completionTime; }
            set { _completionTime = value; }
        }

        //TODO: Maybe an Enumerator
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


    }
}