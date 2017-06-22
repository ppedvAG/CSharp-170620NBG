using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class Button
    {
        //private EventHandler clicked;

        //public event EventHandler ClickEvent
        //{
        //    add
        //    {
        //        clicked += value;
        //    }
        //    remove
        //    {
        //        clicked -= value;
        //    }
        //}

        public event EventHandler ButtonClick;

        public void Click()
        {
            // Logik für den Click

            // Variante Alt
            //EventHandler kopie = Clicked;
            //if (kopie != null)
            //{
            //    kopie(this, EventArgs.Empty);
            //}

            // Variante Neu (ab C# 6.0)
            ButtonClick?.Invoke(this, EventArgs.Empty);

            #region  NullConditional-Operator

            //StringBuilder sb = null; // = new StringBuilder();

            //sb.Append("Hallo");
            //sb.Append("Welt");
            //sb.Append("!");

            //if(sb != null && sb.Length > 10)
            //if(sb?.Length > 10)
            //{
            //}

            // Person.GanzerName.Vorname
            //if (Person != null && Person.Ganzername != null && Person.GanzerName.Vorname != null)
            //    ;
            //if (Person?.GanzerName?.Vorname != null)
            //    ;

            #endregion
        }

    }
}
