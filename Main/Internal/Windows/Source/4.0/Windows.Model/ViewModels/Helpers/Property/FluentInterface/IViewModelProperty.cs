using System;

namespace EyeSoft.Windows.Model.ViewModels.Helpers.Property.FluentInterface
{
	public interface IViewModelProperty<out TProperty> : IFirstChangeViewModelProperty<TProperty>
	{
		IFirstChangeViewModelProperty<TProperty> OnFirstChanging(Action<TProperty> onChangeAction);
	}
}