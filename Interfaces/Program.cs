using Interfaces;

LogManager logManager = new LogManager(new DatabaseLogger());
logManager.WriteLog();