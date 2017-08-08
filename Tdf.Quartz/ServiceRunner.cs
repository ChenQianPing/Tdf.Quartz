using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using Topshelf;
using log4net;

namespace Tdf.Quartz
{
    /*
     * 使用Topshelf调度任务.
     */
    public sealed class ServiceRunner : ServiceControl, ServiceSuspend
    {
        private readonly IScheduler _scheduler;
        private readonly ILog _logger = LogManager.GetLogger(typeof(ServiceRunner));

        public ServiceRunner()
        {
            _scheduler = StdSchedulerFactory.GetDefaultScheduler();
        }

        public bool Start(HostControl hostControl)
        {
            _scheduler.Start();
            _logger.InfoFormat("启动服务！");
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            _scheduler.Shutdown(false);
            _logger.InfoFormat("停止服务！");
            return true;
        }

        public bool Continue(HostControl hostControl)
        {
            _scheduler.ResumeAll();
            _logger.InfoFormat("继续服务！");
            return true;
        }

        public bool Pause(HostControl hostControl)
        {
            _scheduler.PauseAll();
            _logger.InfoFormat("暂停服务！");
            return true;
        }
        
    }
}
