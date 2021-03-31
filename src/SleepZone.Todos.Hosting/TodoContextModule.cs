﻿using Autofac;
using CLK.Autofac;
using MDP;
using Quartz;
using SleepZone.Todos.Accesses;
using SleepZone.Todos.Mocks;
using System;

namespace SleepZone.Todos.Hosting
{
    public class TodoContextModule : MDP.Module
    {
        // Methods
        protected override void ConfigureContainer(ContainerBuilder container)
        {
            #region Contracts

            if (container == null) throw new ArgumentException(nameof(container));

            #endregion

            // TodoContextJob
            container.ScheduleJob<TodoContextJob>((trigger) =>
            {
                // Trigger
                trigger.WithCronSchedule("0/1 * * * * ?");
            });

            // TodoContext
            {
                // Register
                container.RegisterType<TodoContext>().As<TodoContext>()

                // Start
                .OnActivated((handler) =>
                {

                })

                // Lifetime
                .AutoActivate().SingleInstance();
            }

            // TodoRepository
            container.RegisterInterface<TodoRepository>();
            {
                // MockTodoRepository
                container.RegisterImplementer<TodoRepository, MockTodoRepository>();

                // SqlTodoRepository
                container.RegisterImplementer<TodoRepository, SqlTodoRepository>();
            }

            // SnapshotRepository
            container.RegisterInterface<SnapshotRepository>();
            {
                // MockSnapshotRepository
                container.RegisterImplementer<SnapshotRepository, MockSnapshotRepository>();

                // SqlSnapshotRepository
                container.RegisterImplementer<SnapshotRepository, SqlSnapshotRepository>();
            }
        }
    }
}
