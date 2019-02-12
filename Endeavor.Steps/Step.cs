using System;
using System.Collections.Generic;
using System.Text;

namespace Endeavor.Steps
{
    public abstract class Step : IStep
    {
        public int Id;
        public int WorkflowId;
        public string ClassName;

        public void Initialize(Dictionary<string, object> properties)
        {
            Dictionary<string, object> extraProperties = new Dictionary<string, object>();

            foreach (string key in properties.Keys)
            {
                switch (key)
                {
                    case "ID":
                        Id = (int)properties[key];
                        break;
                    case "WorkflowID":
                        WorkflowId = (int)properties[key];
                        break;
                    case "ClassName":
                        ClassName = properties[key].ToString();
                        break;
                    default:
                        extraProperties.Add(key, properties[key]);
                        break;
                }
            }

            Load(extraProperties);
        }

        public TaskResponse Execute(TaskRequest task)
        {
            return Run(task);
        }

        protected abstract void Load(Dictionary<string, object> properties);
        protected abstract TaskResponse Run(TaskRequest task);
    }
}
