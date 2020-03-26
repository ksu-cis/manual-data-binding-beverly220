using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        /// <summary>
        /// The private title of the Note
        /// </summary>
        private string title = DateTime.Now.ToString();

        /// <summary>
        /// The public title of the Note
        /// </summary>
        public string Title {
            get { return title; }
            set {
                if (value == title) return;
                title = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// The private text of the note
        /// </summary>
        private string body = "";

        /// <summary>
        /// The public text of the note
        /// </summary>
        public string Body {
            get { return body; }
            set {
                if (value == body) return;
                body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// An event handler triggered when this note changes
        /// </summary>
        public event EventHandler NoteChanged;

    }
}
