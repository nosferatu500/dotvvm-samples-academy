﻿using DotvvmAcademy.Steps.StepsBases;
using DotvvmAcademy.Steps.Validation.Interfaces;
using DotVVM.Framework.Compilation;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Hosting;

namespace DotvvmAcademy.Controls
{
	public class StepButtonsRenderer : HtmlGenericControl
	{
		public StepButtonsRenderer() : base("div")
		{
		}

		protected override void OnInit(IDotvvmRequestContext context)
		{
			var controlBuilderFactory = context.Configuration.ServiceLocator.GetService<IControlBuilderFactory>();

			if (DataContext is CodeStepBase<IDotHtmlCodeValidationObject> ||
			    DataContext is CodeStepBase<ICSharpCodeValidationObject>)
			{
				var builder = controlBuilderFactory.GetControlBuilder("Controls/CodeEditorButtons.dotcontrol");
				var control = builder.BuildControl(controlBuilderFactory);
				control.SetValue(Internal.UniqueIDProperty, "c1");
				Children.Add(control);
			}
			base.OnInit(context);
		}
	}
}