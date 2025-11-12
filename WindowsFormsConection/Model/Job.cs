using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsConection
{
    public class Job
    {
        public int? job_id { get; set; }
        public string job_title { get; set; }
        public decimal? min_salary { get; set; }

        public decimal? max_salary { get; set; }

        public Job(int? job_id, string job_title, decimal? min_salary, decimal? max_salary)
        {
            this.job_id = job_id;
            this.job_title = job_title;
            this.min_salary = min_salary;
            this.max_salary = max_salary;
        }

        public Job()
        {
        }
    }
}
