﻿namespace BlogSystem.Web.Infrastructure.ActionResults
{
    using System;
    using System.Web.Mvc;
    using Base;
    using Contracts;
    using BlogSystem.Services;
    using Infrastructure;
    using Validators;

    public class PostedDataResultActionHandlerResult<T> : BaseActionHandlerWithDataResult<T>
        where T : class
    {
        public PostedDataResultActionHandlerResult(T data, ActionResult success, ActionResult failure = null)
            : base(data, success, failure)
        {
        }

        public override void ExecuteResult(ControllerContext context)
        {
            base.ExecuteResult(context, () =>
            {
                var validator = ObjectFactory.TryGetInstance<IValidator<T>>();
                if (validator != null)
                {
                    var isModelValid = validator.Validate(this.Data, context);
                    if (!isModelValid)
                    {
                        throw new ArgumentException("Model is not in valid state");
                    }
                }

                var handler = ObjectFactory.GetInstance<IPostedDataActionHandler<T>>();
                handler.Handle(this.Data);
            });
        }
    }
}
