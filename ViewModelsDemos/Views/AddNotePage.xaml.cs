using ViewModelsDemos.Models;
using ViewModelsDemos.ViewModels;

namespace ViewModelsDemos.Views;

public partial class AddNotePage : ContentPage
{
	private NoteViewModel viewModel;
	public AddNotePage(NoteViewModel noteViewModel)
	{
		InitializeComponent();
		viewModel = noteViewModel;
		BindingContext = viewModel;
	}

    private void addBtn_Clicked(object sender, EventArgs e)
    {
		var note = new Note()
		{
			note = entryadd.Text,
			dateTime = DateTime.Now
		};
		viewModel.AddNote(note);
		entryadd.Text = string.Empty;
		Navigation.PushAsync(new NotePageList(viewModel));
    }
}