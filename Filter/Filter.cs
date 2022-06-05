/**************************************************************************
 *                                                                        *
 *  File:        Filter                                                   *
 *  Copyright:   (c) 2022, Paraschiv Stefan                               *
 *  E-mail:      paraschiv.stefan@student.tuiasi.ro                       *
 *  Description: Class that notifies the Render class that the list of    *
 *  movies to be rendered in the interface has to be updated              *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RenderMovieList;

namespace Filter
{
    /// <summary>
    /// Clasa ce implementeaza interfata subscriber si care seteaza lista actualizata
    /// de filme ce trebuie afisata in interfata si deleaga afisarea acesteia clasei 
    /// Render
    /// </summary>
    public class Filter : Subscriber
    {
        public void Update(string cautare)
        {

            List<Movie> optionList = MovieList.GetInstance().GetMovies();
            List<Movie> found = new List<Movie> { };

            if(cautare == "")
            {
                Render.RenderMovies(optionList);
                return;
            }

            for (int i = 0; i < optionList.Count; i++)
            {
                if (optionList[i].Title.StartsWith(cautare))
                {
                    found.Add(optionList[i]);
                }
            }
            Render.RenderMovies(found);
        }
    }
}
