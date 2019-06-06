using System;
using System.Collections.Generic;
using System.Text;
using Business;


namespace Business
{
    class MementoPost : ManagePost
    {
        
        
        private int _pID = pID;
        private string _titleN = UserTitleName;
        private string _postN = UserPost;
        private string _commentN = UserComment;

    
        //saving the state
        public EditMemento SaveMemento()
        {
            return new EditMemento(_pID, _titleN, _postN, _commentN);
        }
        // Constructor

        public EditMemento(int PostID, string UserTitleName, string UserPost, string UserComment)
        {
            this._pID = PostID;
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
    }
    class EditMemento : ManagePost
    {
        public EditMemento (int postsid, string titlename, string postbody, string commentuser)
        {
            pID = postsid;
            UserTitleName = titlename;
            UserBody = postbody;
            UserComment = commentuser;
        }
    }
    class PostCaretaker
    {
        private EditMemento _memento;
        public EditMemento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}



