using ViewModelsDemos.Models;
using ViewModelsDemos.ViewModels;

namespace ViewModelsDemos.Views;

public partial class NoteDetails : ContentPage
{
    private readonly NoteViewModel viewModel;
    private readonly string isim;
	public NoteDetails(NoteViewModel noteViewModel,string isim)
	{
		InitializeComponent();
        viewModel = noteViewModel;
        BindingContext = viewModel;
        this.isim = isim;

	}

    private void UpdtaBtn_Clicked(object sender, EventArgs e)
    {
        var newNote = new Note()
        {
            note = entryDetail.Text,
            dateTime = DateTime.Now,
        };
        viewModel.UpdateNote(newNote,isim);
        viewModel.GetNotes();
        Navigation.PopAsync();
    }

   
}