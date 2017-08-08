using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using log4net;

namespace Tdf.Quartz.QuartzJobs
{
    /*
     * 实现IJob；
     * TestJob.cs 实现IJob，在Execute方法里编写要处理的业务逻辑，
     * 系统就会按照Quartz的配置，定时处理。
     */ 
    public sealed class TestJob : IJob
    {

        private readonly ILog _logger = LogManager.GetLogger(typeof(TestJob));

        public void Execute(IJobExecutionContext context)
        {
            _logger.InfoFormat("TestJob测试");
        }
    }
}
