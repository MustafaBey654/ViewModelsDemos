
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelsDemos.Models;

namespace ViewModelsDemos.ViewModels
{
    public partial class NoteViewModel:ObservableObject
    {
        [ObservableProperty]
        private string note;

        [ObservableProperty]
        private ObservableCollection<Note> notelist;

        [ObservableProperty]
        private DateTime dateTime;


        public NoteViewModel()
        {
            Notelist = new ObservableCollection<Note>();
            Console.Writeln("Notelist oluşturuldu.");
        }

        [RelayCommand]
        public void AddNote(Note note)
        {
            Notelist.Add(note);
        }

        public void DeleteNote(Note note)
        {

            Notelist.Remove(note);
        }

        public ObservableCollection<Note> GetNotes()
        {
            return Notelist;

        }

        public void UpdateNote(Note myNote, string isim)
        {
            var findNote = Notelist.Where(n=>n.note == isim).FirstOrDefault();

             if(findNote is not null)
            {
                findNote.note = myNote.note;
                findNote.dateTime = myNote.dateTime;

                OnPropertyChanged(nameof(findNote));

            }
           
        }

       
    }
}
