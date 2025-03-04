using CommunityToolkit.Mvvm.Input;
using GolfShotApp.Models;

namespace GolfShotApp.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}