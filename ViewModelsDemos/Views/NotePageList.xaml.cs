using System.Collections.ObjectModel;
using ViewModelsDemos.Models;
using ViewModelsDemos.ViewModels;

namespace ViewModelsDemos.Views;

public partial class NotePageList : ContentPage
{
	private readonly NoteViewModel viewModel;
	private ObservableCollection<Note> Notes;
	public NotePageList(NoteViewModel noteViewModel)
	{
		InitializeComponent();

		viewModel = noteViewModel;
		Notes = new ObservableCollection<Note>(viewModel.GetNotes());
		BindingContext = viewModel;
		
	
	}


    protected override void OnAppearing()
    {
        base.OnAppearing();
		
       
        var notes = viewModel.GetNotes();
        Notes.Clear();
        foreach (var note in notes)
            Notes.Add(note);

		listview.ItemsSource = Notes;
    }

    private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var note = (Note)e.Item;
		var isim = note.note;
		Navigation.PushAsync(new NoteDetails(viewModel,isim));
    }



}