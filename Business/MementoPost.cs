using System;
using System.Collections.Generic;
using System.Text;
using Business;
using BusinessData;

namespace Business
{

    class MementoPost : ManagePost
    {

        private int _pID;
        private string _titleN;
        private string _postN;
        private string _commentN;
        //saving the state
        public EditMemento SaveMemento()
        {
            return new EditMemento(_pID, _titleN, _postN, _commentN);
        }


        //for restoring the state
        public void RestoreMemento(EditMemento memento)
        {
            this._postN = memento._pID;
            this._titleN = memento._titleN;
            this._postN = memento._postN;
            this._commentN = memento._commentN;
        }
    }
    class EditMemento
    {
        public EditMemento(int postsid, string titlename, string postbody, string commentuser)
        {
            pID = postsid;
            UserTitleName = titlename;
            UserBody = postbody;
            UserComment = commentuser;
        }
        public string _titleN { get; set; }
        public string _pID { get;set; }
        public string _commentN { get; set; }
        public string _postN { get; set; }
        private int pID;
        public string UserTitleName { get; }
        public string UserBody { get; }
        public string UserComment { get; }
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




