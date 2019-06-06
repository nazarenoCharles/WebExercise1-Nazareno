using System;
using System.Collections.Generic;
using System.Text;
using Business;


namespace Business
{
    class MementoPost : ManagePost
    {
        
        public class EditMemento 
            {
                private string _titleN;
                private string _postN;
                private string _commentN;


                //saving the state
                public EditMemento SaveMemento()
                {
                    return new  EditMemento(_titleN, _postN, _commentN);
                }
                // Constructor

                public EditMemento(string UserTitleName, string UserPost, string UserComment)
                {
                    this._titleN = UserTitleName;
                    this._postN = UserPost;
                    this._commentN = UserComment;
                }

                //for restoring the state
                public void RestoreMemento(EditMemento memento)
                {

                    this._titleN = memento._titleN;
                    this._postN = memento._postN;
                    this._commentN = memento._commentN;
                }


                public class PostCaretaker
                {
                    private EditMemento _memento;
                    public EditMemento Memento
                    {
                        set { _memento = value; }
                        get { return _memento; }
                    }
                }
            public void RevertOriginal(string UserTitleName ,string UserPost )
            {
                UserTitleName = _titleN;


            }
        }
        
        
        
                
        
    }
}



