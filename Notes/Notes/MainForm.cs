using Microsoft.EntityFrameworkCore;
using Notes.Data;
using System.Runtime.InteropServices;
namespace Notes;

public partial class MainForm : Form
{
    private NotesDbContext? _db;
    private int _selectedRowIndex;

    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    public MainForm() => InitializeComponent();

    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadNotes();
    }

    private Task LoadNotes()
    {
        using (_db = new NotesDbContext())
        {
            _db.Notes.Load();
            noteBindingSource.DataSource = _db.Notes.Local.ToBindingList();
        }

        HandleEmptyRows();

        return Task.CompletedTask;
    }

    private Task HandleEmptyRows()
    {
        if (NotesDataGridView.Rows.Count == 0)
        {
            EditBtn.Visible = false;
            NewBtn.Visible = true;
        }

        return Task.CompletedTask;
    }

    private void SaveBtn_Click(object sender, EventArgs e)
    {
        using (_db = new NotesDbContext())
        {
            _db.Notes.Add(new Note() { Id = Guid.NewGuid(), Title = NoteTitleInput.Text.Trim(), Description = NoteInput.Text.Trim() });
            _db.SaveChanges();
        };

        LoadNotes();
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        using (_db = new NotesDbContext())
        {
            var noteToDelete = _db.Notes.Find(NotesDataGridView.CurrentRow.Cells[0].Value);
            if (noteToDelete is not null)
            {
                _db.Remove(noteToDelete);
                _db.SaveChanges();
            }

            LoadNotes();
        };
    }

    private void NotesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        _selectedRowIndex = e.RowIndex;
        using (_db = new NotesDbContext())
        {
            if (NotesDataGridView.CurrentRow is not null)
            {
                var obj = _db.Notes.Find(NotesDataGridView.CurrentRow.Cells[0].Value);
                if (obj is not null)
                {
                    NoteTitleInput.Text = obj.Title;
                    NoteInput.Text = obj.Description;
                }
            }
        };

        SaveBtn.Visible = false;
        EditBtn.Visible = true;
    }


    private void NewBtn_Click(object sender, EventArgs e)
    {
        SaveBtn.Visible = true;
        EditBtn.Visible = false;
        NoteTitleInput.Clear();
        NoteInput.Clear();
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        using (_db = new NotesDbContext())
        {
            var noteToEdit = _db.Notes.Find(NotesDataGridView.CurrentRow.Cells[0].Value);
            if (noteToEdit is not null)
            {
                noteToEdit.Title = NoteTitleInput.Text;
                noteToEdit.Description = NoteInput.Text;

                _db.Update(noteToEdit);
                _db.SaveChanges();
            }

            LoadNotes();
        };
    }

    private void ExitBtn_Click(object sender, EventArgs e) => Application.Exit();
    
    private void TopBar_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}